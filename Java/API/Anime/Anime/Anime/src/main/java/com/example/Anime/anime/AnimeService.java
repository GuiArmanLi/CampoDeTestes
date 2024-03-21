package com.example.Anime.anime;

import java.util.List;
import java.util.UUID;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;

@Service
public class AnimeService {
    @Autowired
    private AnimeRepository database;

    public ResponseEntity<List<AnimeModel>> findAll() {
        List<AnimeModel> animes = database.findAll();
        return ResponseEntity.status(HttpStatus.ACCEPTED).body(animes);
    }

    public ResponseEntity<AnimeModel> findByTitle(String title) {
        return ResponseEntity.status(HttpStatus.ACCEPTED).body(database.findByTitle(title));
    }

    public ResponseEntity<AnimeModel> save(AnimeModel newAnime) {
        List<AnimeModel> animes = database.findAll();

        for (AnimeModel animeModel : animes) {
            if (animeModel.getTitle().equals(newAnime.getTitle())) {
                return ResponseEntity.status(HttpStatus.BAD_REQUEST).body(animeModel);
            }
        }

        database.save(newAnime);
        return ResponseEntity.status(HttpStatus.ACCEPTED).body(newAnime);
    }

    // public String upDate(AnimeModel updatedAnime) {
    // return db.save(updatedAnime);
    // }

    public ResponseEntity<AnimeModel> delete(UUID id) {
        database.deleteById(id);
        return ResponseEntity.status(HttpStatus.ACCEPTED).body(null);
    }
}
