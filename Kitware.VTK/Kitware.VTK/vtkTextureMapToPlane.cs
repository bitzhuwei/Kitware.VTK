using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTextureMapToPlane : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextureMapToPlane";

		public new static readonly string MRClassNameKey;

		static vtkTextureMapToPlane()
		{
			vtkTextureMapToPlane.MRClassNameKey = "class vtkTextureMapToPlane";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextureMapToPlane.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextureMapToPlane"));
		}

		public vtkTextureMapToPlane(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToPlane_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextureMapToPlane New()
		{
			vtkTextureMapToPlane result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextureMapToPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTextureMapToPlane() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTextureMapToPlane.vtkTextureMapToPlane_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_AutomaticPlaneGenerationOff_01(HandleRef pThis);

		public virtual void AutomaticPlaneGenerationOff()
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_AutomaticPlaneGenerationOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_AutomaticPlaneGenerationOn_02(HandleRef pThis);

		public virtual void AutomaticPlaneGenerationOn()
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_AutomaticPlaneGenerationOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTextureMapToPlane_GetAutomaticPlaneGeneration_03(HandleRef pThis);

		public virtual int GetAutomaticPlaneGeneration()
		{
			return vtkTextureMapToPlane.vtkTextureMapToPlane_GetAutomaticPlaneGeneration_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToPlane_GetNormal_04(HandleRef pThis);

		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_GetNormal_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_GetNormal_05(HandleRef pThis, IntPtr data);

		public virtual void GetNormal(IntPtr data)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_GetNormal_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToPlane_GetOrigin_06(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_GetOrigin_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_GetOrigin_07(HandleRef pThis, IntPtr data);

		public virtual void GetOrigin(IntPtr data)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_GetOrigin_07(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToPlane_GetPoint1_08(HandleRef pThis);

		public virtual double[] GetPoint1()
		{
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_GetPoint1_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_GetPoint1_09(HandleRef pThis, IntPtr data);

		public virtual void GetPoint1(IntPtr data)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_GetPoint1_09(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToPlane_GetPoint2_10(HandleRef pThis);

		public virtual double[] GetPoint2()
		{
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_GetPoint2_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_GetPoint2_11(HandleRef pThis, IntPtr data);

		public virtual void GetPoint2(IntPtr data)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_GetPoint2_11(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToPlane_GetSRange_12(HandleRef pThis);

		public virtual double[] GetSRange()
		{
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_GetSRange_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_GetSRange_13(HandleRef pThis, IntPtr data);

		public virtual void GetSRange(IntPtr data)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_GetSRange_13(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToPlane_GetTRange_14(HandleRef pThis);

		public virtual double[] GetTRange()
		{
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_GetTRange_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_GetTRange_15(HandleRef pThis, IntPtr data);

		public virtual void GetTRange(IntPtr data)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_GetTRange_15(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTextureMapToPlane_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTextureMapToPlane.vtkTextureMapToPlane_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTextureMapToPlane_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTextureMapToPlane.vtkTextureMapToPlane_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToPlane_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTextureMapToPlane NewInstance()
		{
			vtkTextureMapToPlane result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextureMapToPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToPlane_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextureMapToPlane SafeDownCast(vtkObjectBase o)
		{
			vtkTextureMapToPlane vtkTextureMapToPlane = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextureMapToPlane.vtkTextureMapToPlane_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextureMapToPlane = (vtkTextureMapToPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextureMapToPlane.Register(null);
				}
			}
			return vtkTextureMapToPlane;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_SetAutomaticPlaneGeneration_21(HandleRef pThis, int _arg);

		public virtual void SetAutomaticPlaneGeneration(int _arg)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetAutomaticPlaneGeneration_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_SetNormal_22(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetNormal_22(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_SetNormal_23(HandleRef pThis, IntPtr _arg);

		public virtual void SetNormal(IntPtr _arg)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetNormal_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_SetOrigin_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetOrigin_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_SetOrigin_25(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetOrigin_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_SetPoint1_26(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPoint1(double _arg1, double _arg2, double _arg3)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetPoint1_26(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_SetPoint1_27(HandleRef pThis, IntPtr _arg);

		public virtual void SetPoint1(IntPtr _arg)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetPoint1_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_SetPoint2_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPoint2(double _arg1, double _arg2, double _arg3)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetPoint2_28(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_SetPoint2_29(HandleRef pThis, IntPtr _arg);

		public virtual void SetPoint2(IntPtr _arg)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetPoint2_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_SetSRange_30(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetSRange(double _arg1, double _arg2)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetSRange_30(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_SetSRange_31(HandleRef pThis, IntPtr _arg);

		public void SetSRange(IntPtr _arg)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetSRange_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_SetTRange_32(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetTRange(double _arg1, double _arg2)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetTRange_32(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToPlane_SetTRange_33(HandleRef pThis, IntPtr _arg);

		public void SetTRange(IntPtr _arg)
		{
			vtkTextureMapToPlane.vtkTextureMapToPlane_SetTRange_33(base.GetCppThis(), _arg);
		}
	}
}
