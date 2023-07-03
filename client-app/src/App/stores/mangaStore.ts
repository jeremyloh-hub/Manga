import axios from "axios";
import { makeAutoObservable, runInAction } from "mobx";
import { Manga } from "../Interface/Manga";

export default class MangaStore {
  mangas: Manga[] = [];

  constructor() {
    makeAutoObservable(this);
  }

  loadMangas = async () => {
    try {
      const response = await axios.get("http://localhost:5000/api/mangas");
      const mangas = response.data;
      runInAction(() => {
        this.mangas = mangas;
      });
    } catch (error) {
      console.log(error);
    }
  };
}
