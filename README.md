🧠 Scenario:
You're building a Shape Drawing System that supports rendering different shapes like Circle, Rectangle, and Triangle on a canvas.

Later, you need to introduce a TextBox which has a position and dimensions like a shape, but instead of being drawn like a shape, it renders text.

🎯 Objectives:
Apply LSP:
Ensure that any subclass used in place of a base class doesn’t break functionality.
For example, if Shape has a method Draw(), any subclass should implement it without unexpected behavior.

Apply ISP:
Split large interfaces so that classes only implement what they need.
TextBox might not need a DrawShape() but may need RenderText().

✅ Requirements:
Define an interface or abstract class for IShape with appropriate methods like Draw(), MoveTo(x, y).

Implement Circle, Rectangle, and Triangle classes that follow LSP and ISP.

Add a TextBox class that shares some behavior with shapes (like position) but does not break LSP when added.

Make sure you don't force TextBox to implement methods like Draw() if it doesn’t make sense.

Add a class called CanvasRenderer which takes a list of IRenderable elements (shapes, textboxes) and renders them without needing to know the exact type.

