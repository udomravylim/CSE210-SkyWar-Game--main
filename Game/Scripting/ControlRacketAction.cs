using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class ControlRacketAction : Action
    {
        private KeyboardService keyboardService;

        public ControlRacketAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Racket ship = (Racket)cast.GetFirstActor(Constants.RACKET_GROUP);
            if (keyboardService.IsKeyDown(Constants.LEFT))
            {
                ship.SwingLeft();
            }
            else if (keyboardService.IsKeyDown(Constants.RIGHT))
            {
                ship.SwingRight();
            }

            else if (keyboardService.IsKeyDown(Constants.UP))
            {
                ship.SwingUp();
            }
            else if (keyboardService.IsKeyDown(Constants.DOWN))
            {
                ship.SwingDown();
            }
            else
            {
                ship.StopMoving();
            }
        }    
    }
}