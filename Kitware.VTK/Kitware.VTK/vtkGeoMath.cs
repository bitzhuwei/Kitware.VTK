using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoMath : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoMath";

		public new static readonly string MRClassNameKey;

		static vtkGeoMath()
		{
			vtkGeoMath.MRClassNameKey = "class vtkGeoMath";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoMath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoMath"));
		}

		public vtkGeoMath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoMath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoMath New()
		{
			vtkGeoMath result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoMath.vtkGeoMath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoMath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoMath() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoMath.vtkGeoMath_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkGeoMath_DistanceSquared_01(IntPtr pt0, IntPtr pt1);

		public static double DistanceSquared(IntPtr pt0, IntPtr pt1)
		{
			return vtkGeoMath.vtkGeoMath_DistanceSquared_01(pt0, pt1);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkGeoMath_EarthRadiusMeters_02();

		public static double EarthRadiusMeters()
		{
			return vtkGeoMath.vtkGeoMath_EarthRadiusMeters_02();
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGeoMath_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoMath.vtkGeoMath_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGeoMath_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoMath.vtkGeoMath_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGeoMath_LongLatAltToRect_05(IntPtr lla, IntPtr rect);

		public static void LongLatAltToRect(IntPtr lla, IntPtr rect)
		{
			vtkGeoMath.vtkGeoMath_LongLatAltToRect_05(lla, rect);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoMath_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoMath NewInstance()
		{
			vtkGeoMath result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoMath.vtkGeoMath_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoMath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoMath_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoMath SafeDownCast(vtkObjectBase o)
		{
			vtkGeoMath vtkGeoMath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoMath.vtkGeoMath_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoMath = (vtkGeoMath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoMath.Register(null);
				}
			}
			return vtkGeoMath;
		}
	}
}
