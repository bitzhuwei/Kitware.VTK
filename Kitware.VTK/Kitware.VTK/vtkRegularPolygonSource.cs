using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRegularPolygonSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRegularPolygonSource";

		public new static readonly string MRClassNameKey;

		static vtkRegularPolygonSource()
		{
			vtkRegularPolygonSource.MRClassNameKey = "class vtkRegularPolygonSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRegularPolygonSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRegularPolygonSource"));
		}

		public vtkRegularPolygonSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRegularPolygonSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRegularPolygonSource New()
		{
			vtkRegularPolygonSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRegularPolygonSource.vtkRegularPolygonSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRegularPolygonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRegularPolygonSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRegularPolygonSource.vtkRegularPolygonSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRegularPolygonSource_GeneratePolygonOff_01(HandleRef pThis);

		public virtual void GeneratePolygonOff()
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_GeneratePolygonOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRegularPolygonSource_GeneratePolygonOn_02(HandleRef pThis);

		public virtual void GeneratePolygonOn()
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_GeneratePolygonOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRegularPolygonSource_GeneratePolylineOff_03(HandleRef pThis);

		public virtual void GeneratePolylineOff()
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_GeneratePolylineOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRegularPolygonSource_GeneratePolylineOn_04(HandleRef pThis);

		public virtual void GeneratePolylineOn()
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_GeneratePolylineOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRegularPolygonSource_GetCenter_05(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkRegularPolygonSource.vtkRegularPolygonSource_GetCenter_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRegularPolygonSource_GetCenter_06(HandleRef pThis, IntPtr data);

		public virtual void GetCenter(IntPtr data)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_GetCenter_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRegularPolygonSource_GetGeneratePolygon_07(HandleRef pThis);

		public virtual int GetGeneratePolygon()
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetGeneratePolygon_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRegularPolygonSource_GetGeneratePolyline_08(HandleRef pThis);

		public virtual int GetGeneratePolyline()
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetGeneratePolyline_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRegularPolygonSource_GetNormal_09(HandleRef pThis);

		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkRegularPolygonSource.vtkRegularPolygonSource_GetNormal_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRegularPolygonSource_GetNormal_10(HandleRef pThis, IntPtr data);

		public virtual void GetNormal(IntPtr data)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_GetNormal_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRegularPolygonSource_GetNumberOfSides_11(HandleRef pThis);

		public virtual int GetNumberOfSides()
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetNumberOfSides_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRegularPolygonSource_GetNumberOfSidesMaxValue_12(HandleRef pThis);

		public virtual int GetNumberOfSidesMaxValue()
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetNumberOfSidesMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRegularPolygonSource_GetNumberOfSidesMinValue_13(HandleRef pThis);

		public virtual int GetNumberOfSidesMinValue()
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetNumberOfSidesMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRegularPolygonSource_GetRadius_14(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_GetRadius_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRegularPolygonSource_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRegularPolygonSource_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRegularPolygonSource.vtkRegularPolygonSource_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRegularPolygonSource_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRegularPolygonSource NewInstance()
		{
			vtkRegularPolygonSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRegularPolygonSource.vtkRegularPolygonSource_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRegularPolygonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRegularPolygonSource_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRegularPolygonSource SafeDownCast(vtkObjectBase o)
		{
			vtkRegularPolygonSource vtkRegularPolygonSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRegularPolygonSource.vtkRegularPolygonSource_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRegularPolygonSource = (vtkRegularPolygonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRegularPolygonSource.Register(null);
				}
			}
			return vtkRegularPolygonSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRegularPolygonSource_SetCenter_20(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetCenter_20(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRegularPolygonSource_SetCenter_21(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetCenter_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRegularPolygonSource_SetGeneratePolygon_22(HandleRef pThis, int _arg);

		public virtual void SetGeneratePolygon(int _arg)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetGeneratePolygon_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRegularPolygonSource_SetGeneratePolyline_23(HandleRef pThis, int _arg);

		public virtual void SetGeneratePolyline(int _arg)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetGeneratePolyline_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRegularPolygonSource_SetNormal_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetNormal_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRegularPolygonSource_SetNormal_25(HandleRef pThis, IntPtr _arg);

		public virtual void SetNormal(IntPtr _arg)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetNormal_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRegularPolygonSource_SetNumberOfSides_26(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSides(int _arg)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetNumberOfSides_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRegularPolygonSource_SetRadius_27(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkRegularPolygonSource.vtkRegularPolygonSource_SetRadius_27(base.GetCppThis(), _arg);
		}
	}
}
