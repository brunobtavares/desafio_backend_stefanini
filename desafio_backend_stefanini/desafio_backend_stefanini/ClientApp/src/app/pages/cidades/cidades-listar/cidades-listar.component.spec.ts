import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CidadesListarComponent } from './cidades-listar.component';

describe('CidadesListarComponent', () => {
  let component: CidadesListarComponent;
  let fixture: ComponentFixture<CidadesListarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CidadesListarComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CidadesListarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
