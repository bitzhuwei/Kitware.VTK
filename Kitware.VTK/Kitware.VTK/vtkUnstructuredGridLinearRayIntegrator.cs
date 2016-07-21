using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnstructuredGridLinearRayIntegrator : vtkUnstructuredGridVolumeRayIntegrator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridLinearRayIntegrator";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridLinearRayIntegrator()
		{
			vtkUnstructuredGridLinearRayIntegrator.MRClassNameKey = "class vtkUnstructuredGridLinearRayIntegrator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridLinearRayIntegrator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridLinearRayIntegrator"));
		}

		public vtkUnstructuredGridLinearRayIntegrator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridLinearRayIntegrator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridLinearRayIntegrator New()
		{
			vtkUnstructuredGridLinearRayIntegrator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridLinearRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnstructuredGridLinearRayIntegrator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridLinearRayIntegrator_Initialize_01(HandleRef pThis, HandleRef volume, HandleRef scalars);

		public override void Initialize(vtkVolume volume, vtkDataArray scalars)
		{
			vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_Initialize_01(base.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridLinearRayIntegrator_Integrate_02(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

		public override void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
		{
			vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_Integrate_02(base.GetCppThis(), (intersectionLengths == null) ? default(HandleRef) : intersectionLengths.GetCppThis(), (nearIntersections == null) ? default(HandleRef) : nearIntersections.GetCppThis(), (farIntersections == null) ? default(HandleRef) : farIntersections.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridLinearRayIntegrator_IntegrateRay_03(double length, double intensity_front, double attenuation_front, double intensity_back, double attenuation_back, IntPtr color);

		public static void IntegrateRay(double length, double intensity_front, double attenuation_front, double intensity_back, double attenuation_back, IntPtr color)
		{
			vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_IntegrateRay_03(length, intensity_front, attenuation_front, intensity_back, attenuation_back, color);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridLinearRayIntegrator_IntegrateRay_04(double length, IntPtr color_front, double attenuation_front, IntPtr color_back, double attenuation_back, IntPtr color);

		public static void IntegrateRay(double length, IntPtr color_front, double attenuation_front, IntPtr color_back, double attenuation_back, IntPtr color)
		{
			vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_IntegrateRay_04(length, color_front, attenuation_front, color_back, attenuation_back, color);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridLinearRayIntegrator_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridLinearRayIntegrator_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridLinearRayIntegrator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridLinearRayIntegrator NewInstance()
		{
			vtkUnstructuredGridLinearRayIntegrator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridLinearRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridLinearRayIntegrator_Psi_09(float length, float attenuation_front, float attenuation_back);

		public static float Psi(float length, float attenuation_front, float attenuation_back)
		{
			return vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_Psi_09(length, attenuation_front, attenuation_back);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridLinearRayIntegrator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridLinearRayIntegrator SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridLinearRayIntegrator vtkUnstructuredGridLinearRayIntegrator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridLinearRayIntegrator = (vtkUnstructuredGridLinearRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridLinearRayIntegrator.Register(null);
				}
			}
			return vtkUnstructuredGridLinearRayIntegrator;
		}
	}
}
