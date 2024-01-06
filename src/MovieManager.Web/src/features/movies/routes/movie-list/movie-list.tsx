import React from "react";
import { useMovies } from "../../api/getMovies";

export const MovieList = () => {
  const moviesQuery = useMovies();
  if (moviesQuery.isLoading) return <>loading...</>;
  if (!moviesQuery.data) return null;
  return (
    <>
      <div>
        <h1>{moviesQuery.data.length}</h1>
      </div>
    </>
  );
};
