using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTextSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextSource";

		public new static readonly string MRClassNameKey;

		static vtkTextSource()
		{
			vtkTextSource.MRClassNameKey = "class vtkTextSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextSource"));
		}

		public vtkTextSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextSource New()
		{
			vtkTextSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextSource.vtkTextSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTextSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTextSource.vtkTextSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextSource_BackingOff_01(HandleRef pThis);

		public virtual void BackingOff()
		{
			vtkTextSource.vtkTextSource_BackingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextSource_BackingOn_02(HandleRef pThis);

		public virtual void BackingOn()
		{
			vtkTextSource.vtkTextSource_BackingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextSource_GetBackgroundColor_03(HandleRef pThis);

		public virtual double[] GetBackgroundColor()
		{
			IntPtr intPtr = vtkTextSource.vtkTextSource_GetBackgroundColor_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextSource_GetBackgroundColor_04(HandleRef pThis, IntPtr data);

		public virtual void GetBackgroundColor(IntPtr data)
		{
			vtkTextSource.vtkTextSource_GetBackgroundColor_04(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTextSource_GetBacking_05(HandleRef pThis);

		public virtual int GetBacking()
		{
			return vtkTextSource.vtkTextSource_GetBacking_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextSource_GetForegroundColor_06(HandleRef pThis);

		public virtual double[] GetForegroundColor()
		{
			IntPtr intPtr = vtkTextSource.vtkTextSource_GetForegroundColor_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextSource_GetForegroundColor_07(HandleRef pThis, IntPtr data);

		public virtual void GetForegroundColor(IntPtr data)
		{
			vtkTextSource.vtkTextSource_GetForegroundColor_07(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextSource_GetText_08(HandleRef pThis);

		public virtual string GetText()
		{
			return Marshal.PtrToStringAnsi(vtkTextSource.vtkTextSource_GetText_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTextSource_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTextSource.vtkTextSource_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTextSource_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTextSource.vtkTextSource_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextSource_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTextSource NewInstance()
		{
			vtkTextSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextSource.vtkTextSource_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextSource_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextSource SafeDownCast(vtkObjectBase o)
		{
			vtkTextSource vtkTextSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextSource.vtkTextSource_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextSource = (vtkTextSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextSource.Register(null);
				}
			}
			return vtkTextSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextSource_SetBackgroundColor_14(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
		{
			vtkTextSource.vtkTextSource_SetBackgroundColor_14(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextSource_SetBackgroundColor_15(HandleRef pThis, IntPtr _arg);

		public virtual void SetBackgroundColor(IntPtr _arg)
		{
			vtkTextSource.vtkTextSource_SetBackgroundColor_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextSource_SetBacking_16(HandleRef pThis, int _arg);

		public virtual void SetBacking(int _arg)
		{
			vtkTextSource.vtkTextSource_SetBacking_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextSource_SetForegroundColor_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetForegroundColor(double _arg1, double _arg2, double _arg3)
		{
			vtkTextSource.vtkTextSource_SetForegroundColor_17(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextSource_SetForegroundColor_18(HandleRef pThis, IntPtr _arg);

		public virtual void SetForegroundColor(IntPtr _arg)
		{
			vtkTextSource.vtkTextSource_SetForegroundColor_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextSource_SetText_19(HandleRef pThis, string _arg);

		public virtual void SetText(string _arg)
		{
			vtkTextSource.vtkTextSource_SetText_19(base.GetCppThis(), _arg);
		}
	}
}
