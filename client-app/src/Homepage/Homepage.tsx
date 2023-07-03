import React, { useEffect } from "react";
import MangaCard from "../Components/MangaCard";
import { observer } from "mobx-react-lite";
import NavBar from "../NavBar/NavBar";
import { useStore } from "../App/stores/store";

function Homepage() {
  const { mangaStore } = useStore();
  const { loadMangas, mangas } = mangaStore;

  useEffect(() => {
    loadMangas();
  }, [loadMangas]);

  return (
    <>
      <NavBar />
      <div className="App flex justify-center items-center">
        <div className="grid grid-cols-3 gap-4">
          {mangas.map((manga) => (
            <MangaCard key={manga.id} manga={manga} />
          ))}
        </div>
      </div>
    </>
  );
}

export default observer(Homepage);
