import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CidadesIncluirComponent } from './cidades-incluir.component';

describe('CidadesIncluirComponent', () => {
  let component: CidadesIncluirComponent;
  let fixture: ComponentFixture<CidadesIncluirComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CidadesIncluirComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CidadesIncluirComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
