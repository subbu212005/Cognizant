import { ComponentFixture, TestBed } from '@angular/core/testing';
import { LoadingSpinnerComponent } from './loading-spinner';
import { LoadingService } from '../../services/loading.service';
import { By } from '@angular/platform-browser';

describe('LoadingSpinnerComponent', () => {
  let component: LoadingSpinnerComponent;
  let fixture: ComponentFixture<LoadingSpinnerComponent>;
  let loadingService: LoadingService;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LoadingSpinnerComponent],
      providers: [LoadingService]
    }).compileComponents();

    fixture = TestBed.createComponent(LoadingSpinnerComponent);
    component = fixture.componentInstance;
    loadingService = TestBed.inject(LoadingService);
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should not show spinner when isLoading is false', () => {
    // Default is false
    const overlay = fixture.debugElement.query(By.css('#loading-spinner-overlay'));
    expect(overlay).toBeNull();
  });

  it('should show spinner when isLoading is true', () => {
    loadingService.show();
    fixture.detectChanges();

    const overlay = fixture.debugElement.query(By.css('#loading-spinner-overlay'));
    expect(overlay).not.toBeNull();

    const text = fixture.debugElement.query(By.css('.spinner-text')).nativeElement;
    expect(text.textContent).toContain('Loading...');
  });
});
