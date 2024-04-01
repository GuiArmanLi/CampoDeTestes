package com.example.Anime.anime;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;
import org.springframework.http.HttpStatus;
import java.util.List;

@Service
public class AnimeService {
    @Autowired
    private IAnime database;

    public ResponseEntity<List<AnimeModel>> findAll() {
        List<AnimeModel> animes = database.findAll();

        return ResponseEntity.status(HttpStatus.ACCEPTED).body(animes);
    }

    public ResponseEntity<AnimeModel> findByTitle(String title) {
        var animeFound = database.findByTitle(title);

        if (animeFound.isPresent()) {
            return ResponseEntity.status(HttpStatus.OK).body(animeFound.get());
        } else {
            return ResponseEntity.status(HttpStatus.BAD_REQUEST).body(null);
        }
    }

    public ResponseEntity<AnimeModel> save(AnimeModel newAnime) {
        List<AnimeModel> animes = database.findAll();

        for (AnimeModel anime : animes) {
            if (anime.getTitle().equals(newAnime.getTitle())) {
                return ResponseEntity.status(HttpStatus.BAD_REQUEST).body(anime);
            }
        }

        database.save(newAnime);
        return ResponseEntity.status(HttpStatus.ACCEPTED).body(newAnime);
    }

    // public String upDate(AnimeModel updatedAnime) {
    // return db.save(updatedAnime);
    // }

    public ResponseEntity<AnimeModel> delete(String title) {
        var animeFound = database.findByTitle(title);

        if (animeFound.isPresent()) {
            var animeDeleted = database.deleteByTitle(title);
            return ResponseEntity.status(HttpStatus.ACCEPTED).body(animeDeleted);
        }

        return ResponseEntity.status(HttpStatus.BAD_REQUEST).body(null);
    }
}
