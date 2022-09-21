#import "DXItemsEditBase.h"
#import "DXAutocompleteEditDelegate.h"

FOUNDATION_EXPORT DXTextChangedReason const _Nonnull DXTextChangedReasonSuggestionChosen;

@interface DXAutocompleteEdit : DXItemsEditBase

@property(nonatomic, nullable, weak) id<DXAutocompleteEditDelegate> delegate;
@property(nonatomic, nullable, readonly) DXIconSettings *searchIcon;
@property(nonatomic) DXIconMode searchIconVisibility;
@property(nonatomic, nullable) NSString *noSuggestionsText;
@property(nonatomic) BOOL loadingInProgress;
@property(nonatomic) BOOL loadingProgressAutoMode;
@property(nullable, nonatomic) UIColor *activityIndicatorColor;

-(void)handleSuggestionChosen;

@end
