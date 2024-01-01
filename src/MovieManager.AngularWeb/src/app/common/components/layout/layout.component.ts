import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from 'src/app/app-routing.module';

@Component({
  selector: 'app-layout',
  standalone: true,
  imports: [CommonModule,    AppRoutingModule],
  templateUrl: './layout.component.html'
})
export class LayoutComponent {

}
