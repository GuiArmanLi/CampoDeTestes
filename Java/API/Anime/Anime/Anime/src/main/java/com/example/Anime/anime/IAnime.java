package com.example.Anime.anime;

import java.util.Optional;
import java.util.UUID;

import org.springframework.data.jpa.repository.JpaRepository;

interface IAnime extends JpaRepository<AnimeModel, UUID> {
    Optional<AnimeModel> findByTitle(String title);

    AnimeModel deleteByTitle(String title);
}
