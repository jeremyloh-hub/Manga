import e from "express";
import { createBrowserRouter, RouteObject } from "react-router-dom";
import Homepage from "../../Homepage/Homepage";
import App from "../App";
import MangaDetails from "../Manga/MangaDetails";

export const routes: RouteObject[] = [
  {
    path: "/",
    element: <App />,
    children: [
      { path: "", element: <Homepage /> },
      { path: "manga", element: <MangaDetails /> },
    ],
  },
];

export const router = createBrowserRouter(routes);
