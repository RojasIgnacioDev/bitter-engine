using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitterEngine.Source;

namespace BitterEngine;
class DemoGame : BitterEngine.Source.BitterEngine {
    public DemoGame() : base(new Vector2(800, 600), "BitterEngine demo") { }

    public override void OnLoad() {
        Console.WriteLine("yay");
    }

    public override void OnUpdate() {

        Console.WriteLine($"Frame {Frame}");
        Frame++;
    }

    public override void OnDraw()
    {

    }
}