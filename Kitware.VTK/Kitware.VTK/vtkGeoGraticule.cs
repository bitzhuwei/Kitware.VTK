using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoGraticule : vtkPolyDataAlgorithm
	{
		public enum GeometryType
		{
			POLYLINES = 1,
			QUADRILATERALS
		}

		public enum LevelLimits
		{
			LEVEL_MAX = 11,
			LEVEL_MIN = 0,
			NUMBER_OF_LEVELS = 12
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoGraticule";

		public new static readonly string MRClassNameKey;

		static vtkGeoGraticule()
		{
			vtkGeoGraticule.MRClassNameKey = "class vtkGeoGraticule";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoGraticule.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoGraticule"));
		}

		public vtkGeoGraticule(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoGraticule_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoGraticule New()
		{
			vtkGeoGraticule result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoGraticule.vtkGeoGraticule_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoGraticule)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoGraticule() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoGraticule.vtkGeoGraticule_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoGraticule_GetGeometryType_01(HandleRef pThis);

		public virtual int GetGeometryType()
		{
			return vtkGeoGraticule.vtkGeoGraticule_GetGeometryType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoGraticule_GetLatitudeBounds_02(HandleRef pThis);

		public virtual double[] GetLatitudeBounds()
		{
			IntPtr intPtr = vtkGeoGraticule.vtkGeoGraticule_GetLatitudeBounds_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoGraticule_GetLatitudeBounds_03(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetLatitudeBounds(ref double _arg1, ref double _arg2)
		{
			vtkGeoGraticule.vtkGeoGraticule_GetLatitudeBounds_03(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoGraticule_GetLatitudeBounds_04(HandleRef pThis, IntPtr _arg);

		public virtual void GetLatitudeBounds(IntPtr _arg)
		{
			vtkGeoGraticule.vtkGeoGraticule_GetLatitudeBounds_04(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoGraticule_GetLatitudeDelta_05(int level);

		public static double GetLatitudeDelta(int level)
		{
			return vtkGeoGraticule.vtkGeoGraticule_GetLatitudeDelta_05(level);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoGraticule_GetLatitudeLevel_06(HandleRef pThis);

		public virtual int GetLatitudeLevel()
		{
			return vtkGeoGraticule.vtkGeoGraticule_GetLatitudeLevel_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoGraticule_GetLatitudeLevelMaxValue_07(HandleRef pThis);

		public virtual int GetLatitudeLevelMaxValue()
		{
			return vtkGeoGraticule.vtkGeoGraticule_GetLatitudeLevelMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoGraticule_GetLatitudeLevelMinValue_08(HandleRef pThis);

		public virtual int GetLatitudeLevelMinValue()
		{
			return vtkGeoGraticule.vtkGeoGraticule_GetLatitudeLevelMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoGraticule_GetLongitudeBounds_09(HandleRef pThis);

		public virtual double[] GetLongitudeBounds()
		{
			IntPtr intPtr = vtkGeoGraticule.vtkGeoGraticule_GetLongitudeBounds_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoGraticule_GetLongitudeBounds_10(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetLongitudeBounds(ref double _arg1, ref double _arg2)
		{
			vtkGeoGraticule.vtkGeoGraticule_GetLongitudeBounds_10(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoGraticule_GetLongitudeBounds_11(HandleRef pThis, IntPtr _arg);

		public virtual void GetLongitudeBounds(IntPtr _arg)
		{
			vtkGeoGraticule.vtkGeoGraticule_GetLongitudeBounds_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoGraticule_GetLongitudeDelta_12(int level);

		public static double GetLongitudeDelta(int level)
		{
			return vtkGeoGraticule.vtkGeoGraticule_GetLongitudeDelta_12(level);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoGraticule_GetLongitudeLevel_13(HandleRef pThis);

		public virtual int GetLongitudeLevel()
		{
			return vtkGeoGraticule.vtkGeoGraticule_GetLongitudeLevel_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoGraticule_GetLongitudeLevelMaxValue_14(HandleRef pThis);

		public virtual int GetLongitudeLevelMaxValue()
		{
			return vtkGeoGraticule.vtkGeoGraticule_GetLongitudeLevelMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoGraticule_GetLongitudeLevelMinValue_15(HandleRef pThis);

		public virtual int GetLongitudeLevelMinValue()
		{
			return vtkGeoGraticule.vtkGeoGraticule_GetLongitudeLevelMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoGraticule_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoGraticule.vtkGeoGraticule_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoGraticule_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoGraticule.vtkGeoGraticule_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoGraticule_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoGraticule NewInstance()
		{
			vtkGeoGraticule result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoGraticule.vtkGeoGraticule_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoGraticule)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoGraticule_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoGraticule SafeDownCast(vtkObjectBase o)
		{
			vtkGeoGraticule vtkGeoGraticule = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoGraticule.vtkGeoGraticule_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoGraticule = (vtkGeoGraticule)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoGraticule.Register(null);
				}
			}
			return vtkGeoGraticule;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoGraticule_SetGeometryType_21(HandleRef pThis, int _arg);

		public virtual void SetGeometryType(int _arg)
		{
			vtkGeoGraticule.vtkGeoGraticule_SetGeometryType_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoGraticule_SetLatitudeBounds_22(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetLatitudeBounds(double _arg1, double _arg2)
		{
			vtkGeoGraticule.vtkGeoGraticule_SetLatitudeBounds_22(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoGraticule_SetLatitudeBounds_23(HandleRef pThis, IntPtr _arg);

		public void SetLatitudeBounds(IntPtr _arg)
		{
			vtkGeoGraticule.vtkGeoGraticule_SetLatitudeBounds_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoGraticule_SetLatitudeLevel_24(HandleRef pThis, int _arg);

		public virtual void SetLatitudeLevel(int _arg)
		{
			vtkGeoGraticule.vtkGeoGraticule_SetLatitudeLevel_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoGraticule_SetLongitudeBounds_25(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetLongitudeBounds(double _arg1, double _arg2)
		{
			vtkGeoGraticule.vtkGeoGraticule_SetLongitudeBounds_25(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoGraticule_SetLongitudeBounds_26(HandleRef pThis, IntPtr _arg);

		public void SetLongitudeBounds(IntPtr _arg)
		{
			vtkGeoGraticule.vtkGeoGraticule_SetLongitudeBounds_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoGraticule_SetLongitudeLevel_27(HandleRef pThis, int _arg);

		public virtual void SetLongitudeLevel(int _arg)
		{
			vtkGeoGraticule.vtkGeoGraticule_SetLongitudeLevel_27(base.GetCppThis(), _arg);
		}
	}
}
