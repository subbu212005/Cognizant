import { TestBed } from '@angular/core/testing';
import { UnitComponent } from './unit';

describe('UnitComponent',()=>{
 beforeEach(async()=>{
  await TestBed.configureTestingModule({
   imports:[UnitComponent]
  }).compileComponents();
 });

 it('should create',()=>{
  const fixture=TestBed.createComponent(UnitComponent);
  expect(fixture.componentInstance).toBeTruthy();
 });

 it('should have correct title',()=>{
  const fixture=TestBed.createComponent(UnitComponent);
  expect(fixture.componentInstance.title).toBe('Angular Unit Testing');
 });
});
