using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtentTranslator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtentTranslator";

		public new static readonly string MRClassNameKey;

		static vtkExtentTranslator()
		{
			vtkExtentTranslator.MRClassNameKey = "class vtkExtentTranslator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtentTranslator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtentTranslator"));
		}

		public vtkExtentTranslator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkExtentTranslator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtentTranslator New()
		{
			vtkExtentTranslator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtentTranslator.vtkExtentTranslator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtentTranslator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtentTranslator.vtkExtentTranslator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkExtentTranslator_GetExtent_01(HandleRef pThis);

		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkExtentTranslator.vtkExtentTranslator_GetExtent_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_GetExtent_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkExtentTranslator.vtkExtentTranslator_GetExtent_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_GetExtent_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetExtent(IntPtr _arg)
		{
			vtkExtentTranslator.vtkExtentTranslator_GetExtent_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentTranslator_GetGhostLevel_04(HandleRef pThis);

		public virtual int GetGhostLevel()
		{
			return vtkExtentTranslator.vtkExtentTranslator_GetGhostLevel_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentTranslator_GetNumberOfPieces_05(HandleRef pThis);

		public virtual int GetNumberOfPieces()
		{
			return vtkExtentTranslator.vtkExtentTranslator_GetNumberOfPieces_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentTranslator_GetPiece_06(HandleRef pThis);

		public virtual int GetPiece()
		{
			return vtkExtentTranslator.vtkExtentTranslator_GetPiece_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentTranslator_GetSplitMode_07(HandleRef pThis);

		public virtual int GetSplitMode()
		{
			return vtkExtentTranslator.vtkExtentTranslator_GetSplitMode_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkExtentTranslator_GetWholeExtent_08(HandleRef pThis);

		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkExtentTranslator.vtkExtentTranslator_GetWholeExtent_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_GetWholeExtent_09(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkExtentTranslator.vtkExtentTranslator_GetWholeExtent_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_GetWholeExtent_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkExtentTranslator.vtkExtentTranslator_GetWholeExtent_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentTranslator_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtentTranslator.vtkExtentTranslator_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentTranslator_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtentTranslator.vtkExtentTranslator_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkExtentTranslator_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtentTranslator NewInstance()
		{
			vtkExtentTranslator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtentTranslator.vtkExtentTranslator_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentTranslator_PieceToExtent_15(HandleRef pThis);

		public virtual int PieceToExtent()
		{
			return vtkExtentTranslator.vtkExtentTranslator_PieceToExtent_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentTranslator_PieceToExtentByPoints_16(HandleRef pThis);

		public virtual int PieceToExtentByPoints()
		{
			return vtkExtentTranslator.vtkExtentTranslator_PieceToExtentByPoints_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkExtentTranslator_PieceToExtentThreadSafe_17(HandleRef pThis, int piece, int numPieces, int ghostLevel, IntPtr wholeExtent, IntPtr resultExtent, int splitMode, int byPoints);

		public virtual int PieceToExtentThreadSafe(int piece, int numPieces, int ghostLevel, IntPtr wholeExtent, IntPtr resultExtent, int splitMode, int byPoints)
		{
			return vtkExtentTranslator.vtkExtentTranslator_PieceToExtentThreadSafe_17(base.GetCppThis(), piece, numPieces, ghostLevel, wholeExtent, resultExtent, splitMode, byPoints);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkExtentTranslator_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtentTranslator SafeDownCast(vtkObjectBase o)
		{
			vtkExtentTranslator vtkExtentTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtentTranslator.vtkExtentTranslator_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtentTranslator = (vtkExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtentTranslator.Register(null);
				}
			}
			return vtkExtentTranslator;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_SetExtent_19(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetExtent_19(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_SetExtent_20(HandleRef pThis, IntPtr _arg);

		public virtual void SetExtent(IntPtr _arg)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetExtent_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_SetGhostLevel_21(HandleRef pThis, int _arg);

		public virtual void SetGhostLevel(int _arg)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetGhostLevel_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_SetNumberOfPieces_22(HandleRef pThis, int _arg);

		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetNumberOfPieces_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_SetPiece_23(HandleRef pThis, int _arg);

		public virtual void SetPiece(int _arg)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetPiece_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_SetSplitModeToBlock_24(HandleRef pThis);

		public void SetSplitModeToBlock()
		{
			vtkExtentTranslator.vtkExtentTranslator_SetSplitModeToBlock_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_SetSplitModeToXSlab_25(HandleRef pThis);

		public void SetSplitModeToXSlab()
		{
			vtkExtentTranslator.vtkExtentTranslator_SetSplitModeToXSlab_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_SetSplitModeToYSlab_26(HandleRef pThis);

		public void SetSplitModeToYSlab()
		{
			vtkExtentTranslator.vtkExtentTranslator_SetSplitModeToYSlab_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_SetSplitModeToZSlab_27(HandleRef pThis);

		public void SetSplitModeToZSlab()
		{
			vtkExtentTranslator.vtkExtentTranslator_SetSplitModeToZSlab_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_SetSplitPath_28(HandleRef pThis, int len, IntPtr splitpath);

		public void SetSplitPath(int len, IntPtr splitpath)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetSplitPath_28(base.GetCppThis(), len, splitpath);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_SetWholeExtent_29(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetWholeExtent_29(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkExtentTranslator_SetWholeExtent_30(HandleRef pThis, IntPtr _arg);

		public virtual void SetWholeExtent(IntPtr _arg)
		{
			vtkExtentTranslator.vtkExtentTranslator_SetWholeExtent_30(base.GetCppThis(), _arg);
		}
	}
}
