package com.example.Anime.anime;

import org.springframework.beans.BeanUtils;
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

    public ResponseEntity<AnimeModel> upDate(String title, AnimeModel updatedAnime) {
        var animeFound = database.findByTitle(title);

        // Copiar propriedades, verificar quais sao iguais e atribuir ao anime guardado
        if (animeFound.isPresent()) {
            BeanUtils.copyProperties(animeFound.get(), updatedAnime);

            // Mudar retorno
            return ResponseEntity.status(HttpStatus.ACCEPTED).body(null);
        }

        return ResponseEntity.status(HttpStatus.BAD_REQUEST).body(null);
    }

    public ResponseEntity<AnimeModel> delete(String title) {
        var animeFound = database.findByTitle(title);

        if (animeFound.isPresent()) {
            var animeDeleted = database.deleteByTitle(title);
            return ResponseEntity.status(HttpStatus.ACCEPTED).body(animeDeleted);
        }

        return ResponseEntity.status(HttpStatus.BAD_REQUEST).body(null);
    }
}
