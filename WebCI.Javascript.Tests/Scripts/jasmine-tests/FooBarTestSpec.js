/// <reference path="../../../WebCI/app/FooBar.js" />

describe("FooBar", function () {
  var fooBar;

  beforeEach(function() {
    fooBar = new FooBar();
  });

  it("should be able to return text", function() {
    expect(fooBar.getText()).toEqual("FooBar");

  });
});
