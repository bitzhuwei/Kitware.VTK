using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTessellatedBoxSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTessellatedBoxSource";

		public new static readonly string MRClassNameKey;

		static vtkTessellatedBoxSource()
		{
			vtkTessellatedBoxSource.MRClassNameKey = "class vtkTessellatedBoxSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTessellatedBoxSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTessellatedBoxSource"));
		}

		public vtkTessellatedBoxSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTessellatedBoxSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTessellatedBoxSource New()
		{
			vtkTessellatedBoxSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTessellatedBoxSource.vtkTessellatedBoxSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTessellatedBoxSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTessellatedBoxSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTessellatedBoxSource.vtkTessellatedBoxSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatedBoxSource_DuplicateSharedPointsOff_01(HandleRef pThis);

		public virtual void DuplicateSharedPointsOff()
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_DuplicateSharedPointsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatedBoxSource_DuplicateSharedPointsOn_02(HandleRef pThis);

		public virtual void DuplicateSharedPointsOn()
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_DuplicateSharedPointsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTessellatedBoxSource_GetBounds_03(HandleRef pThis);

		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatedBoxSource_GetBounds_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		public virtual void GetBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetBounds_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatedBoxSource_GetBounds_05(HandleRef pThis, IntPtr _arg);

		public virtual void GetBounds(IntPtr _arg)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetBounds_05(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTessellatedBoxSource_GetDuplicateSharedPoints_06(HandleRef pThis);

		public virtual int GetDuplicateSharedPoints()
		{
			return vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetDuplicateSharedPoints_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTessellatedBoxSource_GetLevel_07(HandleRef pThis);

		public virtual int GetLevel()
		{
			return vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetLevel_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTessellatedBoxSource_GetQuads_08(HandleRef pThis);

		public virtual int GetQuads()
		{
			return vtkTessellatedBoxSource.vtkTessellatedBoxSource_GetQuads_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTessellatedBoxSource_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTessellatedBoxSource.vtkTessellatedBoxSource_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTessellatedBoxSource_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTessellatedBoxSource.vtkTessellatedBoxSource_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTessellatedBoxSource_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTessellatedBoxSource NewInstance()
		{
			vtkTessellatedBoxSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTessellatedBoxSource.vtkTessellatedBoxSource_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTessellatedBoxSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatedBoxSource_QuadsOff_13(HandleRef pThis);

		public virtual void QuadsOff()
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_QuadsOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatedBoxSource_QuadsOn_14(HandleRef pThis);

		public virtual void QuadsOn()
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_QuadsOn_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTessellatedBoxSource_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTessellatedBoxSource SafeDownCast(vtkObjectBase o)
		{
			vtkTessellatedBoxSource vtkTessellatedBoxSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTessellatedBoxSource.vtkTessellatedBoxSource_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTessellatedBoxSource = (vtkTessellatedBoxSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTessellatedBoxSource.Register(null);
				}
			}
			return vtkTessellatedBoxSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatedBoxSource_SetBounds_16(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_SetBounds_16(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatedBoxSource_SetBounds_17(HandleRef pThis, IntPtr _arg);

		public virtual void SetBounds(IntPtr _arg)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_SetBounds_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatedBoxSource_SetDuplicateSharedPoints_18(HandleRef pThis, int _arg);

		public virtual void SetDuplicateSharedPoints(int _arg)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_SetDuplicateSharedPoints_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatedBoxSource_SetLevel_19(HandleRef pThis, int _arg);

		public virtual void SetLevel(int _arg)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_SetLevel_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTessellatedBoxSource_SetQuads_20(HandleRef pThis, int _arg);

		public virtual void SetQuads(int _arg)
		{
			vtkTessellatedBoxSource.vtkTessellatedBoxSource_SetQuads_20(base.GetCppThis(), _arg);
		}
	}
}
