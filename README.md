# FSESS - Formula Space Engineers Standard Script

### Version 6.0.0 Beta

This is the standard script that all cars racing on FSE should be using on Season 6 and it features:
- Pit Limiter
- Drag Reduction System (DRS)
- Onboard Race Information
- Tire Degradation
- Dynamic Thruster Downforce

## How to Setup
1. Place a Programmable Block on your car;
2. Place a Light Panel at the back of your car, then create  group with it called "Brakelight";
3. Optionally, if your programmable block is not visible from the backpit, you can place a LCD to show onboard information, name it "Driver LCD";
4. Open the Control Panel, look for your Programmable Block, click on the "Edit" button, then copy and paste the script;
5. Make sure to set the following variables according to your needs:
   - DRIVER_NAME => Replace "Guest" to "Your Name"
   - DRIVER_NUMBER => Set a number of your preference from 0 to 99, make sure no other driver uses it.
   - DEFAULT_SUSPENSION_STRENGTH => Set the strength percentage you use on your car suspensions, remember to put an "f" at the end of the number, e.g.: 6.32f;
6. Most of times you won't change the following variables, but optionally you can set:
   - DEFAULT_SUSPENSION_POWER => Set the power percentage you use on your car suspensions, remember to put an "f" at the end of the number;
   - DEFAULT_SUSPENSION_SPEED_LIMIT => Set the top speed you use on your car suspensions, remember to put an "f" at the end of the number;
7. If you want to see onboard race information (Current Lap, Position, Lap Time, Tire Wear), make sure to set the ADDRESS of the current track, so the race control can send race data to your car (you must have an Antenna on your car to receive data). 
8. Once you have set the values, click on "Check Code" button, a success message should pop-up (if not,repeat the previous steps);
9. After closing the pop-up, click on "OK" on the Editor;
10. Setup the arguments to the Programmable Block on your car's hotbar, so you can execute commands for your cockpit, then you're ready to race.

**Note: After setting this up, your grid name will change to the standardized name "DRIVER_NUMBER-DRIVER_NAME", e.g.: "21-Cratera".**

## Arguments
Here's a list of all arguments supported by the current script:
- LMT    => Toggle Pit Limiter
- DRS    => Toggle Drag Reduction System (DRS)
- ULTRA  => Switch to Ultra-Soft Tires
- SOFT   => Switch to Soft Tires
- MEDIUM => Switch to Medium Tires
- HARD   => Switch to Hard Tires

## Tire Degradation
Season 6 is going to feature tire degradation, wheels are going to get less friction overtime, affecting the overall performance of your car. You're going to be able to see the Tire Wear % on your onboard screen, once it reachs 0% a random wheels is going to pop-off your car as a puncture.

In order to change wheels, you have to go to the pits, with the Pit Limiter active, fully stop your car, then you are going to be able to switch tires using the arguments: ULTRA, SOFT, MEDIUM, HARD. Notice that once you change tires, the Tire Wear % changes to 100%, also a letter going to be displayed reprsenting the selected compound (U, S, M, H) and your Brakelight is going to change the color making your current compound visible to the others. The image bellow show the specs for each compound type:

![alt text](https://i.imgur.com/Csqdrym.png)

**Note: For now, the drive style won't matter too much on the tire degradation rate, it will be pretty similar to everyone. The degradation rate is only based on current speed (even if the wheels are not touching the ground), the faster you go, the faster your tire will degradate. (At 90m/s it reachs the maximum rate)**

## FAQ
- **How does the DRS works?**
  - It set the strength of all your suspensions to 100% while active, which allows your car to reach 100m/s. But be careful, it might only be good to use on long straights, also bumpy surfaces might put your car in the air while DRS is active.
  
- **Do I need to setup FSESS script on my car to be detected by the race control script?"**
  - No, once you cross the start line you are already being tracked. But in order to see your onboard race data, using commands and having the tire degradation effect on your car, you need to setup this script on your car.
  
- **Is there anyway to stop the tire degradation?**
  - No, unless you turn off your Programable Block (which would be cheating during a race). There is a discussion about preventing tire degradation when Pit Limiter is active, but for now, make sure to change tire before it's too late.
  
- **What is the Dynamic Thruster Downforce?**
  - It is an experimental feature which will use a downwards thruster on your car to apply downforce to it proportional to the current speed. Its usage still under discussion, but if you want to try, just put a thruster on your car and recompile the script, it will detect it and control it. It's an attempt to reduce the bounceness experienced by the drivers during the races.

- **Why these values for the tires?**
  - Well, the lifespan are based on the Fibonacci sequence, notice that if you sum the lifespan of ULTRA + SOFT = MEDIUM, also SOFT + MEDIUM = HARD, this allow a good variety of strategies on the races. Also, the friction ranges are planned in a way so all the compounds have 20% of the lifespan bellow 50% friction, so people can optionally push the wheels to the limit even if they are getting a low performance. Your onboard display gonna show a "Tires Worn" warning when it reachs 20%, you can use that as a sign to go to the pits.
