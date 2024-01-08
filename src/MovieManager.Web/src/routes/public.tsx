import React, { Suspense } from "react";
import { Navigate, Outlet } from "react-router-dom";

import { MainLayout } from "../components/Layout/MainLayout";

import { lazyImport } from "../utils/lazyImport";
const { MoviesRoutes } = lazyImport(
  () => import("../features/movies"),
  "MoviesRoutes"
);
export const App = () => {
  return (
    <>
      <MainLayout>
        <Suspense fallback={<></>}>
          <Outlet />
        </Suspense>
      </MainLayout>
    </>
  );
};
export const publicRoutes = [
  {
    path: "/",
    element: <App />,
    children: [
      { path: "/movies/*", element: <MoviesRoutes /> },
      { path: "*", element: <Navigate to="." /> },
    ],
  },
];
