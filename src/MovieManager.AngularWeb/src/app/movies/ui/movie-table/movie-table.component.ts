import { AfterViewInit, Component, ViewChild, Input, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MovieModel } from 'src/app/shared/ui/models/movie/movie.model';
import {MatPaginator, MatPaginatorModule} from '@angular/material/paginator';
import {MatSort, MatSortModule} from '@angular/material/sort';
import {MatTableDataSource, MatTableModule} from '@angular/material/table';
@Component({
  selector: 'app-movie-table',
  standalone: true,
  imports: [CommonModule, MatTableModule, MatSortModule, MatPaginatorModule],
  templateUrl: './movie-table.component.html',
})
export class MovieTableComponent implements OnInit  {

  @Input() movies: MovieModel[];
  @Input() filter: string = "";
  displayedColumns: string[] = [ 'name', 'description'];
  dataSource: MatTableDataSource<MovieModel>;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;
  constructor() {

  }
  ngOnInit() {
    this.dataSource = new MatTableDataSource(this.movies);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }
}
