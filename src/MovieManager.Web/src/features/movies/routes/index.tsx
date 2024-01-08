import { Navigate, Route, Routes } from "react-router-dom";
import { MovieDetailPage } from "../pages/movie-detail.page";
import { MoviesPage } from "../pages/movies.page";

export const MoviesRoutes = () => {
  return (
    <Routes>
      <Route path="" element={<MoviesPage />} />
      <Route path=":movieId" element={<MovieDetailPage />} />
      <Route path="create" element={<MovieDetailPage />} />
      <Route path="*" element={<Navigate to="." />} />
    </Routes>
  );
};
