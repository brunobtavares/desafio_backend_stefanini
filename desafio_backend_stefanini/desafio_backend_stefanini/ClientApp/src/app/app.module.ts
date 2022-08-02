import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { NgSelectModule } from '@ng-select/ng-select';
import { NgxMaskModule } from 'ngx-mask';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { CidadesAlterarComponent } from './pages/cidades/cidades-alterar/cidades-alterar.component';
import { CidadesIncluirComponent } from './pages/cidades/cidades-incluir/cidades-incluir.component';
import { CidadesListarComponent } from './pages/cidades/cidades-listar/cidades-listar.component';
import { PessoasAlterarComponent } from './pages/pessoas/pessoas-alterar/pessoas-alterar.component';
import { PessoasIncluirComponent } from './pages/pessoas/pessoas-incluir/pessoas-incluir.component';
import { PessoasListarComponent } from './pages/pessoas/pessoas-listar/pessoas-listar.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    PessoasListarComponent,
    PessoasIncluirComponent,
    PessoasAlterarComponent,
    CidadesListarComponent,
    CidadesIncluirComponent,
    CidadesAlterarComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    NgSelectModule,
    ReactiveFormsModule,
    NgxMaskModule.forRoot(),
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      {
        path: 'pessoas', children: [
          { path: 'listar', component: PessoasListarComponent },
          { path: 'incluir', component: PessoasIncluirComponent },
          { path: 'alterar/:id', component: PessoasAlterarComponent },
        ]
      },
      {
        path: 'cidades', children: [
          { path: 'listar', component: CidadesListarComponent },
          { path: 'incluir', component: CidadesIncluirComponent },
          { path: 'alterar/:id', component: CidadesAlterarComponent }
        ]
      },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
