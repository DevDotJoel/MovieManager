import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './shared/ui/layout/layout.component';

const routes: Routes = [
  {
  path:'',
  component:LayoutComponent,
  children:
          [

            {
              path:'movies',loadChildren:()=> import('./movies/features/movie-shell/movie-shell-routing.module').then(m=>m.MovieShellRoutingModule),
            },
            {
              path:'home',loadComponent:()=> import('./home/home.page.component').then(m=>m.HomePageComponent),

            },
            {
              path:'',redirectTo:'home',pathMatch:'full'
            }
          ]
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules }),
  ],
  exports: [RouterModule],
})
export class AppRoutingModule { }
