using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnstructuredGridPartialPreIntegration : vtkUnstructuredGridVolumeRayIntegrator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridPartialPreIntegration";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridPartialPreIntegration()
		{
			vtkUnstructuredGridPartialPreIntegration.MRClassNameKey = "class vtkUnstructuredGridPartialPreIntegration";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridPartialPreIntegration.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridPartialPreIntegration"));
		}

		public vtkUnstructuredGridPartialPreIntegration(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridPartialPreIntegration_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridPartialPreIntegration New()
		{
			vtkUnstructuredGridPartialPreIntegration result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridPartialPreIntegration)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnstructuredGridPartialPreIntegration() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridPartialPreIntegration_BuildPsiTable_01();

		public static void BuildPsiTable()
		{
			vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_BuildPsiTable_01();
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridPartialPreIntegration_GetPsiTable_02(ref int size);

		public static IntPtr GetPsiTable(ref int size)
		{
			return vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_GetPsiTable_02(ref size);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridPartialPreIntegration_Initialize_03(HandleRef pThis, HandleRef volume, HandleRef scalars);

		public override void Initialize(vtkVolume volume, vtkDataArray scalars)
		{
			vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_Initialize_03(base.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridPartialPreIntegration_Integrate_04(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

		public override void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
		{
			vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_Integrate_04(base.GetCppThis(), (intersectionLengths == null) ? default(HandleRef) : intersectionLengths.GetCppThis(), (nearIntersections == null) ? default(HandleRef) : nearIntersections.GetCppThis(), (farIntersections == null) ? default(HandleRef) : farIntersections.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridPartialPreIntegration_IntegrateRay_05(double length, double intensity_front, double attenuation_front, double intensity_back, double attenuation_back, IntPtr color);

		public static void IntegrateRay(double length, double intensity_front, double attenuation_front, double intensity_back, double attenuation_back, IntPtr color)
		{
			vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_IntegrateRay_05(length, intensity_front, attenuation_front, intensity_back, attenuation_back, color);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridPartialPreIntegration_IntegrateRay_06(double length, IntPtr color_front, double attenuation_front, IntPtr color_back, double attenuation_back, IntPtr color);

		public static void IntegrateRay(double length, IntPtr color_front, double attenuation_front, IntPtr color_back, double attenuation_back, IntPtr color)
		{
			vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_IntegrateRay_06(length, color_front, attenuation_front, color_back, attenuation_back, color);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridPartialPreIntegration_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridPartialPreIntegration_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridPartialPreIntegration_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridPartialPreIntegration NewInstance()
		{
			vtkUnstructuredGridPartialPreIntegration result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridPartialPreIntegration)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridPartialPreIntegration_Psi_11(float taufD, float taubD);

		public static float Psi(float taufD, float taubD)
		{
			return vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_Psi_11(taufD, taubD);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridPartialPreIntegration_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridPartialPreIntegration SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridPartialPreIntegration vtkUnstructuredGridPartialPreIntegration = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridPartialPreIntegration = (vtkUnstructuredGridPartialPreIntegration)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridPartialPreIntegration.Register(null);
				}
			}
			return vtkUnstructuredGridPartialPreIntegration;
		}
	}
}
