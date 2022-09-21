#import "DXTextEditBase.h"
#import "DXDropdownDelegate.h"
#import "DXDataDelegate.h"
#import "DXItemsEditViewProvider.h"
#import "DXItemsEditDelegate.h"

@interface DXItemsEditBase : DXTextEditBase<DXDropdownDelegate, DXDataDelegate>

@property(nonatomic) BOOL isDropdownOpen;
@property(nonatomic, nullable, weak) id<DXItemsEditDelegate> delegate;
@property(nonatomic, nullable, weak) id<DXItemsEditViewProvider> viewProvider;
@property(nullable, nonatomic) UIColor *dropdownColor;
@property(nullable, nonatomic) UIFont *dropdownItemFont;
@property(nullable, nonatomic) UIColor *dropdownItemFontColor;
@property(nullable, nonatomic) UIColor *dropdownSelectedItemColor;
@property(nullable, nonatomic) UIColor *dropdownSelectedItemFontColor;
@property(nonatomic) UIEdgeInsets dropdownItemPadding;
@property(nonatomic) BOOL keepFocusOnItemSelection;
@property(nullable, nonatomic) UIView *customInternalEditor;

-(void)updateDisplayText;
-(void)resizeOpenFrame;
-(void)updateDisplayTextBySelectedItem;
@end
