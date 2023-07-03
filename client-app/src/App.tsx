import React, { useEffect, useState } from "react";
import "./App.css";
import axios from "axios";
import NavBar from "./NavBar/NavBar";

function App() {
  const [mangas, setMangas] = useState([]);

  useEffect(() => {
    axios.get("http://localhost:5000/api/mangas").then((response) => {
      console.log(response);
      setMangas(response.data);
    });
  }, []);

  return (
    <>
      <NavBar />
      <div className="App flex justify-center items-center">
        <div className="grid grid-cols-3 gap-4">
          {mangas.map((manga: any) => (
            <div key={manga.id} className="card glass w-64">
              <figure>
                <img src={manga.picture} alt="Manga" />
              </figure>
              <div className="card-body">
                <h2 className="card-title centered-title">{manga.title}</h2>
                <div className="card-actions justify-end"></div>
              </div>
            </div>
          ))}
        </div>
      </div>
    </>
  );
}

export default App;
