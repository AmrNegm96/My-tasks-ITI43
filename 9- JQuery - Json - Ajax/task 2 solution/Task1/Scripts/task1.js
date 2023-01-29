// (selector).animate({styles}, para1, para2, para3);
// Styles: It helps to set the new CSS property.
// para1: It is an optional parameter and is used to set the speed of the parameter and its default value is 400 milliseconds.
// para2: It is optional and this specifies the speed of the element at different positions.
// para3: It is an optional function that is used to be performed after the animation is complete.
// Return Value: It returns the change made by using the above method.
// Parameter	Description
// styles	Required. Specifies one or more CSS properties/values to animate.
// Note: The property names must be camel-cased when used with the animate() method: You will need to write paddingLeft instead of padding-left, marginRight instead of margin-right, and so on.

// Properties that can be animated:

// backgroundPositionX
// backgroundPositionY
// borderWidth
// borderBottomWidth
// borderLeftWidth
// borderRightWidth
// borderTopWidth
// borderSpacing
// margin
// marginBottom
// marginLeft
// marginRight
// marginTop
// opacity
// outlineWidth
// padding
// paddingBottom
// paddingLeft
// paddingRight
// paddingTop
// height
// width
// maxHeight
// maxWidth
// minHeight
// minWidth
// fontSize
// bottom
// left
// right
// top
// letterSpacing
// wordSpacing
// lineHeight
// textIndent

// Only numeric values can be animated (like "margin:30px"). String values cannot be animated (like "background-color:red"), except for the strings "show", "hide" and "toggle". These values allow hiding and showing the animated element.
// speed	Optional. Specifies the speed of the animation. Default value is 400 milliseconds
// Possible values:

// milliseconds (like 100, 1000, 5000, etc)
// "slow"
// "fast"
// easing	Optional. Specifies the speed of the element in different points of the animation. Default value is "swing". Possible values:
// "swing" - moves slower at the beginning/end, but faster in the middle
// "linear" - moves in a constant speed
// Tip: More easing functions are available in external plugins.
// callback	Optional. A function to be executed after the animation completes. To learn more about callback, please read our jQuery Callback chapter

// options	Optional. Specifies additional options for the animation. Possible values:
// duration - sets the speed of the animation
// easing - specifies the easing function to use
// complete - specifies a function to be executed after the animation completes
// step - specifies a function to be executed for each step in the animation
// progress - specifies a function to be executed after each step in the animation
// queue - a Boolean value specifying whether or not to place the animation in the effects queue
// specialEasing - a map of one or more CSS properties from the styles parameter, and their corresponding easing functions
// start - specifies a function to be executed when the animation begins
// done - specifies a function to be executed when the animation ends
// fail - specifies a function to be executed if the animation fails to complete
// always - specifies a function to be executed if the animation stops without completing

$("img").animate(
{ left: "1600" },
  {
    duration: 3000,
    step: function (now) {
      $("#type").text(
        '<img src="../Images/12.gif" style="left' + now.toFixed() + '">'
      );
    },
    complete: function () {
      $("img").hide("explode", 3000);
    },
  }
);
