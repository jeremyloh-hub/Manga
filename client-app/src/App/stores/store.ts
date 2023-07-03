import { createContext, useContext } from "react";
import MangaStore from "./mangaStore";

interface Store {
  mangaStore: MangaStore;
}

export const store: Store = {
  mangaStore: new MangaStore(),
};

export const StoreContext = createContext(store);

export function useStore() {
  return useContext(StoreContext);
}
