#import "DXDataFormEditorDelegate.h"

#ifndef DXDataFormEditorItem_h
#define DXDataFormEditorItem_h

@class DataFormValidationError;

@protocol DXDataFormDelegate <NSObject>

-(void)groupIsCollapsedChanging:(int)groupId isCollapsed:(BOOL)isCollapsed;
-(void)groupIsCollapsedChanged:(int)groupId isCollapsed:(BOOL)isCollapsed;
-(void)formSizeDidChanged:(UIView *_Nonnull)dataForm;

@end

@protocol DXDataFormEditorItem

@property (readonly) bool resolveLostFocusInside;
@property bool isActive;
@property (weak, readonly, nullable) UIView *editor;
@property (nonatomic, weak, nullable) id<DXDataFormEditorDelegate> editorDelegate;

-(void) updateValue;
-(DataFormValidationError* _Nullable) preValidate;
-(DataFormValidationError* _Nullable) postValidate;
-(DataFormValidationError* _Nullable) validate;
-(void) postValue;
-(NSObject*_Nullable) getValue;

-(void)configure;

@end

#endif /* DXDataFormEditor_h */
