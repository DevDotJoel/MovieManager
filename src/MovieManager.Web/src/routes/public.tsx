import React from "react";
import { Navigate, Outlet } from "react-router-dom";

import { MainLayout } from "../components/Layout/MainLayout";
import { MovieList } from "../features/movies";

export const App = () => {
  return (
    <>
      <MainLayout>
        <Outlet />
      </MainLayout>
    </>
  );
};
export const publicRoutes = [
  {
    path: "/",
    element: <App />,
    children: [
      { path: "/movies", element: <MovieList /> },
      { path: "*", element: <Navigate to="." /> },
    ],
  },
];
