package com.example.thymeleaf.mangas;

import java.util.UUID;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.stereotype.Service;

@Service
public class MangaService {
    @Autowired
    IMangas mangas;

    public ModelAndView getHome() {
        ModelAndView mw = new ModelAndView("manga");
        mw.addObject("mangas", mangas.findAll());
        return mw;
    }

    public String register(MangaModel newManga) {
        if (newManga.getId() != null && mangas.existsById(newManga.getId())) {
            mangas.deleteById(newManga.getId());
            mangas.save(newManga);

            return "redirect:/mangas";
        }

        mangas.save(newManga);
        return "redirect:/mangas";
    }

    public ModelAndView getById(UUID id) {
        ModelAndView mv = new ModelAndView("edit");

        MangaModel manga = mangas.findMangaById(id);
        mv.addObject("manga", manga);

        return mv;
    }

}
