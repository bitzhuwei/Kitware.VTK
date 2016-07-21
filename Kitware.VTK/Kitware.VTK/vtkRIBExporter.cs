using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRIBExporter : vtkExporter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRIBExporter";

		public new static readonly string MRClassNameKey;

		static vtkRIBExporter()
		{
			vtkRIBExporter.MRClassNameKey = "class vtkRIBExporter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRIBExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRIBExporter"));
		}

		public vtkRIBExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRIBExporter New()
		{
			vtkRIBExporter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRIBExporter.vtkRIBExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRIBExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRIBExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRIBExporter.vtkRIBExporter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBExporter_BackgroundOff_01(HandleRef pThis);

		public virtual void BackgroundOff()
		{
			vtkRIBExporter.vtkRIBExporter_BackgroundOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBExporter_BackgroundOn_02(HandleRef pThis);

		public virtual void BackgroundOn()
		{
			vtkRIBExporter.vtkRIBExporter_BackgroundOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBExporter_ExportArraysOff_03(HandleRef pThis);

		public virtual void ExportArraysOff()
		{
			vtkRIBExporter.vtkRIBExporter_ExportArraysOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBExporter_ExportArraysOn_04(HandleRef pThis);

		public virtual void ExportArraysOn()
		{
			vtkRIBExporter.vtkRIBExporter_ExportArraysOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkRIBExporter_GetBackground_05(HandleRef pThis);

		public virtual int GetBackground()
		{
			return vtkRIBExporter.vtkRIBExporter_GetBackground_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkRIBExporter_GetExportArrays_06(HandleRef pThis);

		public virtual int GetExportArrays()
		{
			return vtkRIBExporter.vtkRIBExporter_GetExportArrays_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkRIBExporter_GetExportArraysMaxValue_07(HandleRef pThis);

		public virtual int GetExportArraysMaxValue()
		{
			return vtkRIBExporter.vtkRIBExporter_GetExportArraysMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkRIBExporter_GetExportArraysMinValue_08(HandleRef pThis);

		public virtual int GetExportArraysMinValue()
		{
			return vtkRIBExporter.vtkRIBExporter_GetExportArraysMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBExporter_GetFilePrefix_09(HandleRef pThis);

		public virtual string GetFilePrefix()
		{
			return Marshal.PtrToStringAnsi(vtkRIBExporter.vtkRIBExporter_GetFilePrefix_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBExporter_GetPixelSamples_10(HandleRef pThis);

		public virtual int[] GetPixelSamples()
		{
			IntPtr intPtr = vtkRIBExporter.vtkRIBExporter_GetPixelSamples_10(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBExporter_GetPixelSamples_11(HandleRef pThis, IntPtr data);

		public virtual void GetPixelSamples(IntPtr data)
		{
			vtkRIBExporter.vtkRIBExporter_GetPixelSamples_11(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBExporter_GetSize_12(HandleRef pThis);

		public virtual int[] GetSize()
		{
			IntPtr intPtr = vtkRIBExporter.vtkRIBExporter_GetSize_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBExporter_GetSize_13(HandleRef pThis, IntPtr data);

		public virtual void GetSize(IntPtr data)
		{
			vtkRIBExporter.vtkRIBExporter_GetSize_13(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBExporter_GetTexturePrefix_14(HandleRef pThis);

		public virtual string GetTexturePrefix()
		{
			return Marshal.PtrToStringAnsi(vtkRIBExporter.vtkRIBExporter_GetTexturePrefix_14(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkRIBExporter_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRIBExporter.vtkRIBExporter_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkRIBExporter_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRIBExporter.vtkRIBExporter_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBExporter_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRIBExporter NewInstance()
		{
			vtkRIBExporter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRIBExporter.vtkRIBExporter_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRIBExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBExporter_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRIBExporter SafeDownCast(vtkObjectBase o)
		{
			vtkRIBExporter vtkRIBExporter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRIBExporter.vtkRIBExporter_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRIBExporter = (vtkRIBExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRIBExporter.Register(null);
				}
			}
			return vtkRIBExporter;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBExporter_SetBackground_20(HandleRef pThis, int _arg);

		public virtual void SetBackground(int _arg)
		{
			vtkRIBExporter.vtkRIBExporter_SetBackground_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBExporter_SetExportArrays_21(HandleRef pThis, int _arg);

		public virtual void SetExportArrays(int _arg)
		{
			vtkRIBExporter.vtkRIBExporter_SetExportArrays_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBExporter_SetFilePrefix_22(HandleRef pThis, string _arg);

		public virtual void SetFilePrefix(string _arg)
		{
			vtkRIBExporter.vtkRIBExporter_SetFilePrefix_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBExporter_SetPixelSamples_23(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetPixelSamples(int _arg1, int _arg2)
		{
			vtkRIBExporter.vtkRIBExporter_SetPixelSamples_23(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBExporter_SetPixelSamples_24(HandleRef pThis, IntPtr _arg);

		public void SetPixelSamples(IntPtr _arg)
		{
			vtkRIBExporter.vtkRIBExporter_SetPixelSamples_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBExporter_SetSize_25(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetSize(int _arg1, int _arg2)
		{
			vtkRIBExporter.vtkRIBExporter_SetSize_25(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBExporter_SetSize_26(HandleRef pThis, IntPtr _arg);

		public void SetSize(IntPtr _arg)
		{
			vtkRIBExporter.vtkRIBExporter_SetSize_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBExporter_SetTexturePrefix_27(HandleRef pThis, string _arg);

		public virtual void SetTexturePrefix(string _arg)
		{
			vtkRIBExporter.vtkRIBExporter_SetTexturePrefix_27(base.GetCppThis(), _arg);
		}
	}
}
