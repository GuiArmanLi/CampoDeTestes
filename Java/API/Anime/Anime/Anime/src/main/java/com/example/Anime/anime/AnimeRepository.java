package com.example.Anime.anime;

import java.util.UUID;

import org.springframework.data.jpa.repository.JpaRepository;

interface AnimeRepository extends JpaRepository<AnimeModel, UUID> {
    AnimeModel findByTitle(String title);
}
