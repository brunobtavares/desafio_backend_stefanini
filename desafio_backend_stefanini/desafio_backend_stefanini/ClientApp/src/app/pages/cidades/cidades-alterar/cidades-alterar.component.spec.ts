import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CidadesAlterarComponent } from './cidades-alterar.component';

describe('CidadesAlterarComponent', () => {
  let component: CidadesAlterarComponent;
  let fixture: ComponentFixture<CidadesAlterarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CidadesAlterarComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CidadesAlterarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
