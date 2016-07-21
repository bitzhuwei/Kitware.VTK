using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageMapToColors : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMapToColors";

		public new static readonly string MRClassNameKey;

		static vtkImageMapToColors()
		{
			vtkImageMapToColors.MRClassNameKey = "class vtkImageMapToColors";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMapToColors.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMapToColors"));
		}

		public vtkImageMapToColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapToColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMapToColors New()
		{
			vtkImageMapToColors result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMapToColors.vtkImageMapToColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageMapToColors() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageMapToColors.vtkImageMapToColors_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMapToColors_GetActiveComponent_01(HandleRef pThis);

		public virtual int GetActiveComponent()
		{
			return vtkImageMapToColors.vtkImageMapToColors_GetActiveComponent_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapToColors_GetLookupTable_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMapToColors.vtkImageMapToColors_GetLookupTable_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern uint vtkImageMapToColors_GetMTime_03(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkImageMapToColors.vtkImageMapToColors_GetMTime_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMapToColors_GetOutputFormat_04(HandleRef pThis);

		public virtual int GetOutputFormat()
		{
			return vtkImageMapToColors.vtkImageMapToColors_GetOutputFormat_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMapToColors_GetPassAlphaToOutput_05(HandleRef pThis);

		public virtual int GetPassAlphaToOutput()
		{
			return vtkImageMapToColors.vtkImageMapToColors_GetPassAlphaToOutput_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMapToColors_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMapToColors.vtkImageMapToColors_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMapToColors_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMapToColors.vtkImageMapToColors_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapToColors_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMapToColors NewInstance()
		{
			vtkImageMapToColors result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMapToColors.vtkImageMapToColors_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMapToColors_PassAlphaToOutputOff_10(HandleRef pThis);

		public virtual void PassAlphaToOutputOff()
		{
			vtkImageMapToColors.vtkImageMapToColors_PassAlphaToOutputOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMapToColors_PassAlphaToOutputOn_11(HandleRef pThis);

		public virtual void PassAlphaToOutputOn()
		{
			vtkImageMapToColors.vtkImageMapToColors_PassAlphaToOutputOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapToColors_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMapToColors SafeDownCast(vtkObjectBase o)
		{
			vtkImageMapToColors vtkImageMapToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMapToColors.vtkImageMapToColors_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapToColors = (vtkImageMapToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapToColors.Register(null);
				}
			}
			return vtkImageMapToColors;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMapToColors_SetActiveComponent_13(HandleRef pThis, int _arg);

		public virtual void SetActiveComponent(int _arg)
		{
			vtkImageMapToColors.vtkImageMapToColors_SetActiveComponent_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMapToColors_SetLookupTable_14(HandleRef pThis, HandleRef arg0);

		public virtual void SetLookupTable(vtkScalarsToColors arg0)
		{
			vtkImageMapToColors.vtkImageMapToColors_SetLookupTable_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMapToColors_SetOutputFormat_15(HandleRef pThis, int _arg);

		public virtual void SetOutputFormat(int _arg)
		{
			vtkImageMapToColors.vtkImageMapToColors_SetOutputFormat_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMapToColors_SetOutputFormatToLuminance_16(HandleRef pThis);

		public void SetOutputFormatToLuminance()
		{
			vtkImageMapToColors.vtkImageMapToColors_SetOutputFormatToLuminance_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMapToColors_SetOutputFormatToLuminanceAlpha_17(HandleRef pThis);

		public void SetOutputFormatToLuminanceAlpha()
		{
			vtkImageMapToColors.vtkImageMapToColors_SetOutputFormatToLuminanceAlpha_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMapToColors_SetOutputFormatToRGB_18(HandleRef pThis);

		public void SetOutputFormatToRGB()
		{
			vtkImageMapToColors.vtkImageMapToColors_SetOutputFormatToRGB_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMapToColors_SetOutputFormatToRGBA_19(HandleRef pThis);

		public void SetOutputFormatToRGBA()
		{
			vtkImageMapToColors.vtkImageMapToColors_SetOutputFormatToRGBA_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMapToColors_SetPassAlphaToOutput_20(HandleRef pThis, int _arg);

		public virtual void SetPassAlphaToOutput(int _arg)
		{
			vtkImageMapToColors.vtkImageMapToColors_SetPassAlphaToOutput_20(base.GetCppThis(), _arg);
		}
	}
}
