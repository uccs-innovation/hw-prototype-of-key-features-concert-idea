#ifndef DXDisplayEdit_h
#define DXDisplayEdit_h


#import <UIKit/UIKit.h>
#import "DXAlignment.h"
#import "DXIconSettings.h"


typedef NS_OPTIONS(NSUInteger, DXTextDecoration) {
    DXTextDecorationUnspecified = 0,    // 0000
    DXTextDecorationNone = 1,           // 0001
    DXTextDecorationUnderline = 3,      // 0011
    DXTextDecorationStrikethrough = 5   // 0101
};

IB_DESIGNABLE
@interface DXDisplayEdit : UIView

//@property(nonatomic) IBInspectable BOOL enabled;
//@property(nonatomic) IBInspectable BOOL hasError;

@property(nullable, nonatomic, copy) IBInspectable NSString *text;
@property(nullable, nonatomic, copy) IBInspectable NSAttributedString *attributedText;
@property(nullable, nonatomic, copy) IBInspectable NSString *prefixText;
@property(nullable, nonatomic, copy) IBInspectable NSString *suffixText;

@property(nullable, nonatomic) IBInspectable UIFont *font;
@property(nullable, nonatomic) IBInspectable UIFont *affixFont;

@property(nonatomic) IBInspectable DXTextDecoration textDecoration;
@property(nonatomic) IBInspectable NSTextAlignment textAlignment;

@property(nullable, nonatomic) IBInspectable UIColor *textColor;
@property(nullable, nonatomic) IBInspectable UIColor *affixColor;
//@property(nullable, nonatomic) IBInspectable UIColor *errorColor;

@property(nonatomic) IBInspectable NSInteger numberOfLines;
@property(nonatomic) IBInspectable CGFloat affixIndent;
@property(nonatomic) IBInspectable CGFloat iconIndent;
@property(nonatomic) IBInspectable CGFloat iconSpacing;
@property(nonatomic) NSLineBreakMode lineBreakMode;

@property(nonatomic) IBInspectable DXVerticalAlignment iconAlignment;
@property(nonatomic) IBInspectable UIEdgeInsets contentEdgeInsets;

@property(nonatomic, readonly) NSInteger leadingIconCount;
@property(nonatomic, readonly) NSInteger trailingIconCount;

//@property(nullable, nonatomic) UIImage *errorIcon;

-(nonnull instancetype)initWithFrame:(CGRect)frame;
-(nullable instancetype)initWithCoder:(nullable NSCoder *)coder;

-(void)addLeadingIcon:(nonnull UIImage *)icon withTint:(nullable UIColor *)tint;
-(void)insertLeadingIcon:(nonnull UIImage *)icon withTint:(nullable UIColor *)tint atIndex:(NSInteger)index;
-(BOOL)removeLeadingIconAtIndex: (NSInteger)index;

-(void)addTrailingIcon:(nonnull UIImage *)icon withTint:(nullable UIColor *)tint;
-(void)insertTrailingIcon:(nonnull UIImage *)icon withTint:(nullable UIColor *)tint atIndex:(NSInteger)index;
-(BOOL)removeTrailingIconAtIndex: (NSInteger)index;

@end


#endif /* DXDisplayEdit_h */
