class List { };
class Cons : List { public int _arg0; public List _arg1;}
class Nil  : List {}

class length {
  public int _run(List _arg0) {
    {
      var lst = _arg0;

      var _tmp0 = lst as Cons;
      if (_tmp0 == null) { goto _skip0; }
      var x = _tmp0._arg0;
      var xs = _tmp0._arg1;

      var _tmp1 = new length();

      var len = _tmp1._run(xs);

      var res = len + 1;

      return res;
    }
_skip0:
    {
      var lst = _arg0;

      var _tmp0 = lst as Nil;
      if (_tmp0 == null) { goto _skip1; }

      var res = 0;

      return res;
    }
_skip1:
    throw new System.Exception();
  }
}

class _main {
  static List makelist(int x, List l) {
    if (x == 0) {
      return l;
    } else {
      Cons c = new Cons();
      c._arg0 = x;
      c._arg1 = l;
      return makelist(x - 1, c);
    }
  }
  static void Main(string[] args) {
    var list = makelist(100000, new Nil());
    for (int i = 0; i < 1000; i++) {
      var stopwatch = new System.Diagnostics.Stopwatch();
      var l = new length();
      stopwatch.Start();
      var result = l._run(list);
      stopwatch.Stop();
      System.Console.WriteLine(stopwatch.Elapsed);
    }
  }
}
