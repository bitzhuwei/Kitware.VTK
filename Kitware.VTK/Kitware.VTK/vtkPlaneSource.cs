using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlaneSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlaneSource";

		public new static readonly string MRClassNameKey;

		static vtkPlaneSource()
		{
			vtkPlaneSource.MRClassNameKey = "class vtkPlaneSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlaneSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlaneSource"));
		}

		public vtkPlaneSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlaneSource New()
		{
			vtkPlaneSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaneSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlaneSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlaneSource.vtkPlaneSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneSource_GetCenter_01(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_GetCenter_02(HandleRef pThis, IntPtr data);

		public virtual void GetCenter(IntPtr data)
		{
			vtkPlaneSource.vtkPlaneSource_GetCenter_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneSource_GetNormal_03(HandleRef pThis);

		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_GetNormal_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_GetNormal_04(HandleRef pThis, IntPtr data);

		public virtual void GetNormal(IntPtr data)
		{
			vtkPlaneSource.vtkPlaneSource_GetNormal_04(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneSource_GetOrigin_05(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_GetOrigin_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_GetOrigin_06(HandleRef pThis, IntPtr data);

		public virtual void GetOrigin(IntPtr data)
		{
			vtkPlaneSource.vtkPlaneSource_GetOrigin_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneSource_GetPoint1_07(HandleRef pThis);

		public virtual double[] GetPoint1()
		{
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_GetPoint1_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_GetPoint1_08(HandleRef pThis, IntPtr data);

		public virtual void GetPoint1(IntPtr data)
		{
			vtkPlaneSource.vtkPlaneSource_GetPoint1_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneSource_GetPoint2_09(HandleRef pThis);

		public virtual double[] GetPoint2()
		{
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_GetPoint2_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_GetPoint2_10(HandleRef pThis, IntPtr data);

		public virtual void GetPoint2(IntPtr data)
		{
			vtkPlaneSource.vtkPlaneSource_GetPoint2_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_GetResolution_11(HandleRef pThis, ref int xR, ref int yR);

		public void GetResolution(ref int xR, ref int yR)
		{
			vtkPlaneSource.vtkPlaneSource_GetResolution_11(base.GetCppThis(), ref xR, ref yR);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPlaneSource_GetXResolution_12(HandleRef pThis);

		public virtual int GetXResolution()
		{
			return vtkPlaneSource.vtkPlaneSource_GetXResolution_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPlaneSource_GetYResolution_13(HandleRef pThis);

		public virtual int GetYResolution()
		{
			return vtkPlaneSource.vtkPlaneSource_GetYResolution_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPlaneSource_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlaneSource.vtkPlaneSource_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPlaneSource_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlaneSource.vtkPlaneSource_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneSource_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlaneSource NewInstance()
		{
			vtkPlaneSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaneSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_Push_18(HandleRef pThis, double distance);

		public void Push(double distance)
		{
			vtkPlaneSource.vtkPlaneSource_Push_18(base.GetCppThis(), distance);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaneSource_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlaneSource SafeDownCast(vtkObjectBase o)
		{
			vtkPlaneSource vtkPlaneSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaneSource.vtkPlaneSource_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneSource = (vtkPlaneSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneSource.Register(null);
				}
			}
			return vtkPlaneSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_SetCenter_20(HandleRef pThis, double x, double y, double z);

		public void SetCenter(double x, double y, double z)
		{
			vtkPlaneSource.vtkPlaneSource_SetCenter_20(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_SetCenter_21(HandleRef pThis, IntPtr center);

		public void SetCenter(IntPtr center)
		{
			vtkPlaneSource.vtkPlaneSource_SetCenter_21(base.GetCppThis(), center);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_SetNormal_22(HandleRef pThis, double nx, double ny, double nz);

		public void SetNormal(double nx, double ny, double nz)
		{
			vtkPlaneSource.vtkPlaneSource_SetNormal_22(base.GetCppThis(), nx, ny, nz);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_SetNormal_23(HandleRef pThis, IntPtr n);

		public void SetNormal(IntPtr n)
		{
			vtkPlaneSource.vtkPlaneSource_SetNormal_23(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_SetOrigin_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkPlaneSource.vtkPlaneSource_SetOrigin_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_SetOrigin_25(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkPlaneSource.vtkPlaneSource_SetOrigin_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_SetPoint1_26(HandleRef pThis, double x, double y, double z);

		public void SetPoint1(double x, double y, double z)
		{
			vtkPlaneSource.vtkPlaneSource_SetPoint1_26(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_SetPoint1_27(HandleRef pThis, IntPtr pnt);

		public void SetPoint1(IntPtr pnt)
		{
			vtkPlaneSource.vtkPlaneSource_SetPoint1_27(base.GetCppThis(), pnt);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_SetPoint2_28(HandleRef pThis, double x, double y, double z);

		public void SetPoint2(double x, double y, double z)
		{
			vtkPlaneSource.vtkPlaneSource_SetPoint2_28(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_SetPoint2_29(HandleRef pThis, IntPtr pnt);

		public void SetPoint2(IntPtr pnt)
		{
			vtkPlaneSource.vtkPlaneSource_SetPoint2_29(base.GetCppThis(), pnt);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_SetResolution_30(HandleRef pThis, int xR, int yR);

		public void SetResolution(int xR, int yR)
		{
			vtkPlaneSource.vtkPlaneSource_SetResolution_30(base.GetCppThis(), xR, yR);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_SetXResolution_31(HandleRef pThis, int _arg);

		public virtual void SetXResolution(int _arg)
		{
			vtkPlaneSource.vtkPlaneSource_SetXResolution_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlaneSource_SetYResolution_32(HandleRef pThis, int _arg);

		public virtual void SetYResolution(int _arg)
		{
			vtkPlaneSource.vtkPlaneSource_SetYResolution_32(base.GetCppThis(), _arg);
		}
	}
}
