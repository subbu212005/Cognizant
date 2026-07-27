import { TestBed } from '@angular/core/testing';
import { unsavedChangesGuard, HasUnsavedChanges } from './unsaved-changes.guard';

describe('unsavedChangesGuard', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({});
    // Mock global confirm function
    vi.stubGlobal('confirm', vi.fn());
  });

  afterEach(() => {
    vi.restoreAllMocks();
  });

  it('should allow navigation when component does not implement hasUnsavedChanges', () => {
    const component = {} as any;
    const result = TestBed.runInInjectionContext(() =>
      unsavedChangesGuard(component, {} as any, {} as any, {} as any)
    );
    expect(result).toBe(true);
  });

  it('should allow navigation when component has no unsaved changes', () => {
    const component: HasUnsavedChanges = {
      hasUnsavedChanges: () => false
    };
    const result = TestBed.runInInjectionContext(() =>
      unsavedChangesGuard(component, {} as any, {} as any, {} as any)
    );
    expect(result).toBe(true);
  });

  it('should prompt user and allow navigation when confirm returns true', () => {
    const component: HasUnsavedChanges = {
      hasUnsavedChanges: () => true
    };
    vi.mocked(confirm).mockReturnValue(true);

    const result = TestBed.runInInjectionContext(() =>
      unsavedChangesGuard(component, {} as any, {} as any, {} as any)
    );

    expect(confirm).toHaveBeenCalled();
    expect(result).toBe(true);
  });

  it('should prompt user and block navigation when confirm returns false', () => {
    const component: HasUnsavedChanges = {
      hasUnsavedChanges: () => true
    };
    vi.mocked(confirm).mockReturnValue(false);

    const result = TestBed.runInInjectionContext(() =>
      unsavedChangesGuard(component, {} as any, {} as any, {} as any)
    );

    expect(confirm).toHaveBeenCalled();
    expect(result).toBe(false);
  });
});
