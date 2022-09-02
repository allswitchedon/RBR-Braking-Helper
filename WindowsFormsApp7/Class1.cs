
using System.Runtime.InteropServices;


namespace WindowsFormsApp7
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class RichardBurnsRallyNGPTelemetryAPI
    {
        public uint totalSteps;
        public RBR_Stage stage;
        public RBR_InputControl control;
        public RBR_Car car;
    }

    public struct RBR_Stage
    {
        public int index;
        public float progress;
        public float raceTime;
        public float driveLineLocation;
        public float distanceToEnd;
    }

    public struct RBR_InputControl
    {
        public float steering;
        public float throttle;
        public float brake;
        public float handbrake;
        public float clutch;
        public int gear;
        public float footbrakePressure;
        public float handbrakePressure;
    }

    public struct RBR_Car
    {
        public int index;
        public float speed;
        public float positionX;
        public float positionY;
        public float positionZ;
        public float roll;
        public float pitch;
        public float yaw;
        public RBR_Motion velocities;
        public RBR_Motion accelerations;
        public RBR_Engine engine;
        public RBR_Suspension suspensionLF;
        public RBR_Suspension suspensionRF;
        public RBR_Suspension suspensionLB;
        public RBR_Suspension suspensionRB;
    }

    public struct RBR_Motion
    {
        public float surge;
        public float sway;
        public float heave;
        public float roll;
        public float pitch;
        public float yaw;
    }

    public struct RBR_Engine
    {
        public float rpm;
        public float radiatorCoolantTemperature;
        public float engineCoolantTemperature;
        public float engineTemperature;
    }

    public struct RBR_Suspension
    {
        public float springDeflection;
        public float rollbarForce;
        public float springForce;
        public float damperForce;
        public float strutForce;
        public int helperSpringIsActive;
        public RBR_Damper damper;
        public RBR_Wheel wheel;
    }

    public struct RBR_Damper
    {
        public float damage;
        public float pistonVelocity;
    }

    public struct RBR_Wheel
    {
        public RBR_BrakeDisk brakeDisk;
        public RBR_Tire tire;
    }
    public struct RBR_BrakeDisk
    {
        public float layerTemperature;
        public float temperature;
        public float wear;
    }

    public struct RBR_Tire
    {
        public float pressure;
        public float temperature;
        public float carcassTemperature;
        public float treadTemperature;
        public uint currentSegment;
        public RBR_TireSegment segment1;
        public RBR_TireSegment segment2;
        public RBR_TireSegment segment3;
        public RBR_TireSegment segment4;
        public RBR_TireSegment segment5;
        public RBR_TireSegment segment6;
        public RBR_TireSegment segment7;
        public RBR_TireSegment segment8;
    }

    public struct RBR_TireSegment
    {
        public float temperature;
        public float wear;
    }
}
