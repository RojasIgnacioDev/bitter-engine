namespace BitterEngine.Source;


class Canvas : Form {
    public Canvas() {
        this.DoubleBuffered = true;
    }
}


public abstract class BitterEngine {
        
    private Vector2 ScreenSize = new Vector2(512, 512);
    private string Title = "Game";
    private Canvas Window;
    private Thread GameLoopThread;
    
    protected int Frame = 0;

    public BitterEngine(Vector2 screenSize, string title) {
            
        this.ScreenSize = screenSize;
        this.Title = title;

        Window = new Canvas();
        Window.Size = new Size((int) this.ScreenSize.X, (int) this.ScreenSize.Y);
        Window.Text = this.Title;
        Window.Paint += Renderer; ;

        GameLoopThread = new Thread(MainGameLoop);
        GameLoopThread.Start();

        Application.Run(Window);

    }

    private void Renderer(object? sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.Clear(Color.BlanchedAlmond);
    }

    void MainGameLoop() {

        OnLoad();

        while(GameLoopThread.IsAlive) {

            try { 
            
                OnDraw();

                // force the window be constantly updating even if it doesn't want it
                Window.BeginInvoke((MethodInvoker)delegate { Window.Refresh(); }); ;

                OnUpdate();

                Thread.Sleep(1);
            } 
            catch {
                Console.WriteLine("Game is loading...");
            }
        }
    }

    public abstract void OnLoad();
    public abstract void OnUpdate();
    public abstract void OnDraw();
}