import React from "react";
import { Manga } from "../App/Interface/Manga";

interface Props {
  manga: Manga;
}

export default function MangaCard({ manga }: Props) {
  return (
    <div key={manga.id} className="card glass w-64">
      <figure>
        <img src={manga.picture} alt="Manga" />
      </figure>
      <div className="card-body">
        <h2 className="card-title centered-title">{manga.title}</h2>
        <div className="card-actions justify-end"></div>
      </div>
    </div>
  );
}
