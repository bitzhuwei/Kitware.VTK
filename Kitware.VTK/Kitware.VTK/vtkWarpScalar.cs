using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWarpScalar : vtkPointSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWarpScalar";

		public new static readonly string MRClassNameKey;

		static vtkWarpScalar()
		{
			vtkWarpScalar.MRClassNameKey = "class vtkWarpScalar";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWarpScalar.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpScalar"));
		}

		public vtkWarpScalar(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpScalar_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWarpScalar New()
		{
			vtkWarpScalar result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWarpScalar.vtkWarpScalar_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpScalar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWarpScalar() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWarpScalar.vtkWarpScalar_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpScalar_GetNormal_01(HandleRef pThis);

		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkWarpScalar.vtkWarpScalar_GetNormal_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpScalar_GetNormal_02(HandleRef pThis, IntPtr data);

		public virtual void GetNormal(IntPtr data)
		{
			vtkWarpScalar.vtkWarpScalar_GetNormal_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWarpScalar_GetScaleFactor_03(HandleRef pThis);

		public virtual double GetScaleFactor()
		{
			return vtkWarpScalar.vtkWarpScalar_GetScaleFactor_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWarpScalar_GetUseNormal_04(HandleRef pThis);

		public virtual int GetUseNormal()
		{
			return vtkWarpScalar.vtkWarpScalar_GetUseNormal_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWarpScalar_GetXYPlane_05(HandleRef pThis);

		public virtual int GetXYPlane()
		{
			return vtkWarpScalar.vtkWarpScalar_GetXYPlane_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWarpScalar_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWarpScalar.vtkWarpScalar_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWarpScalar_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWarpScalar.vtkWarpScalar_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpScalar_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWarpScalar NewInstance()
		{
			vtkWarpScalar result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWarpScalar.vtkWarpScalar_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpScalar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpScalar_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWarpScalar SafeDownCast(vtkObjectBase o)
		{
			vtkWarpScalar vtkWarpScalar = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWarpScalar.vtkWarpScalar_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWarpScalar = (vtkWarpScalar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWarpScalar.Register(null);
				}
			}
			return vtkWarpScalar;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpScalar_SetNormal_11(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkWarpScalar.vtkWarpScalar_SetNormal_11(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpScalar_SetNormal_12(HandleRef pThis, IntPtr _arg);

		public virtual void SetNormal(IntPtr _arg)
		{
			vtkWarpScalar.vtkWarpScalar_SetNormal_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpScalar_SetScaleFactor_13(HandleRef pThis, double _arg);

		public virtual void SetScaleFactor(double _arg)
		{
			vtkWarpScalar.vtkWarpScalar_SetScaleFactor_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpScalar_SetUseNormal_14(HandleRef pThis, int _arg);

		public virtual void SetUseNormal(int _arg)
		{
			vtkWarpScalar.vtkWarpScalar_SetUseNormal_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpScalar_SetXYPlane_15(HandleRef pThis, int _arg);

		public virtual void SetXYPlane(int _arg)
		{
			vtkWarpScalar.vtkWarpScalar_SetXYPlane_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpScalar_UseNormalOff_16(HandleRef pThis);

		public virtual void UseNormalOff()
		{
			vtkWarpScalar.vtkWarpScalar_UseNormalOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpScalar_UseNormalOn_17(HandleRef pThis);

		public virtual void UseNormalOn()
		{
			vtkWarpScalar.vtkWarpScalar_UseNormalOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpScalar_XYPlaneOff_18(HandleRef pThis);

		public virtual void XYPlaneOff()
		{
			vtkWarpScalar.vtkWarpScalar_XYPlaneOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpScalar_XYPlaneOn_19(HandleRef pThis);

		public virtual void XYPlaneOn()
		{
			vtkWarpScalar.vtkWarpScalar_XYPlaneOn_19(base.GetCppThis());
		}
	}
}
