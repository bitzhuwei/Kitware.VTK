using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkArrowSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrowSource";

		public new static readonly string MRClassNameKey;

		static vtkArrowSource()
		{
			vtkArrowSource.MRClassNameKey = "class vtkArrowSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrowSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrowSource"));
		}

		public vtkArrowSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrowSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrowSource New()
		{
			vtkArrowSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrowSource.vtkArrowSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrowSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkArrowSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkArrowSource.vtkArrowSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkArrowSource_GetInvert_01(HandleRef pThis);

		public virtual bool GetInvert()
		{
			return vtkArrowSource.vtkArrowSource_GetInvert_01(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkArrowSource_GetShaftRadius_02(HandleRef pThis);

		public virtual double GetShaftRadius()
		{
			return vtkArrowSource.vtkArrowSource_GetShaftRadius_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkArrowSource_GetShaftRadiusMaxValue_03(HandleRef pThis);

		public virtual double GetShaftRadiusMaxValue()
		{
			return vtkArrowSource.vtkArrowSource_GetShaftRadiusMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkArrowSource_GetShaftRadiusMinValue_04(HandleRef pThis);

		public virtual double GetShaftRadiusMinValue()
		{
			return vtkArrowSource.vtkArrowSource_GetShaftRadiusMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrowSource_GetShaftResolution_05(HandleRef pThis);

		public virtual int GetShaftResolution()
		{
			return vtkArrowSource.vtkArrowSource_GetShaftResolution_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrowSource_GetShaftResolutionMaxValue_06(HandleRef pThis);

		public virtual int GetShaftResolutionMaxValue()
		{
			return vtkArrowSource.vtkArrowSource_GetShaftResolutionMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrowSource_GetShaftResolutionMinValue_07(HandleRef pThis);

		public virtual int GetShaftResolutionMinValue()
		{
			return vtkArrowSource.vtkArrowSource_GetShaftResolutionMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkArrowSource_GetTipLength_08(HandleRef pThis);

		public virtual double GetTipLength()
		{
			return vtkArrowSource.vtkArrowSource_GetTipLength_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkArrowSource_GetTipLengthMaxValue_09(HandleRef pThis);

		public virtual double GetTipLengthMaxValue()
		{
			return vtkArrowSource.vtkArrowSource_GetTipLengthMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkArrowSource_GetTipLengthMinValue_10(HandleRef pThis);

		public virtual double GetTipLengthMinValue()
		{
			return vtkArrowSource.vtkArrowSource_GetTipLengthMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkArrowSource_GetTipRadius_11(HandleRef pThis);

		public virtual double GetTipRadius()
		{
			return vtkArrowSource.vtkArrowSource_GetTipRadius_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkArrowSource_GetTipRadiusMaxValue_12(HandleRef pThis);

		public virtual double GetTipRadiusMaxValue()
		{
			return vtkArrowSource.vtkArrowSource_GetTipRadiusMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkArrowSource_GetTipRadiusMinValue_13(HandleRef pThis);

		public virtual double GetTipRadiusMinValue()
		{
			return vtkArrowSource.vtkArrowSource_GetTipRadiusMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrowSource_GetTipResolution_14(HandleRef pThis);

		public virtual int GetTipResolution()
		{
			return vtkArrowSource.vtkArrowSource_GetTipResolution_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrowSource_GetTipResolutionMaxValue_15(HandleRef pThis);

		public virtual int GetTipResolutionMaxValue()
		{
			return vtkArrowSource.vtkArrowSource_GetTipResolutionMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrowSource_GetTipResolutionMinValue_16(HandleRef pThis);

		public virtual int GetTipResolutionMinValue()
		{
			return vtkArrowSource.vtkArrowSource_GetTipResolutionMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrowSource_InvertOff_17(HandleRef pThis);

		public virtual void InvertOff()
		{
			vtkArrowSource.vtkArrowSource_InvertOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrowSource_InvertOn_18(HandleRef pThis);

		public virtual void InvertOn()
		{
			vtkArrowSource.vtkArrowSource_InvertOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrowSource_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkArrowSource.vtkArrowSource_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrowSource_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkArrowSource.vtkArrowSource_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrowSource_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkArrowSource NewInstance()
		{
			vtkArrowSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrowSource.vtkArrowSource_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrowSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrowSource_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrowSource SafeDownCast(vtkObjectBase o)
		{
			vtkArrowSource vtkArrowSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrowSource.vtkArrowSource_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrowSource = (vtkArrowSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrowSource.Register(null);
				}
			}
			return vtkArrowSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrowSource_SetInvert_24(HandleRef pThis, byte _arg);

		public virtual void SetInvert(bool _arg)
		{
			vtkArrowSource.vtkArrowSource_SetInvert_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrowSource_SetShaftRadius_25(HandleRef pThis, double _arg);

		public virtual void SetShaftRadius(double _arg)
		{
			vtkArrowSource.vtkArrowSource_SetShaftRadius_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrowSource_SetShaftResolution_26(HandleRef pThis, int _arg);

		public virtual void SetShaftResolution(int _arg)
		{
			vtkArrowSource.vtkArrowSource_SetShaftResolution_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrowSource_SetTipLength_27(HandleRef pThis, double _arg);

		public virtual void SetTipLength(double _arg)
		{
			vtkArrowSource.vtkArrowSource_SetTipLength_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrowSource_SetTipRadius_28(HandleRef pThis, double _arg);

		public virtual void SetTipRadius(double _arg)
		{
			vtkArrowSource.vtkArrowSource_SetTipRadius_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrowSource_SetTipResolution_29(HandleRef pThis, int _arg);

		public virtual void SetTipResolution(int _arg)
		{
			vtkArrowSource.vtkArrowSource_SetTipResolution_29(base.GetCppThis(), _arg);
		}
	}
}
