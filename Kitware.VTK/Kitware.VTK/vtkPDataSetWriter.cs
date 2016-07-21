using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPDataSetWriter : vtkDataSetWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPDataSetWriter";

		public new static readonly string MRClassNameKey;

		static vtkPDataSetWriter()
		{
			vtkPDataSetWriter.MRClassNameKey = "class vtkPDataSetWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPDataSetWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPDataSetWriter"));
		}

		public vtkPDataSetWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPDataSetWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPDataSetWriter New()
		{
			vtkPDataSetWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPDataSetWriter.vtkPDataSetWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDataSetWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPDataSetWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPDataSetWriter.vtkPDataSetWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPDataSetWriter_GetEndPiece_01(HandleRef pThis);

		public virtual int GetEndPiece()
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_GetEndPiece_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPDataSetWriter_GetFilePattern_02(HandleRef pThis);

		public virtual string GetFilePattern()
		{
			return Marshal.PtrToStringAnsi(vtkPDataSetWriter.vtkPDataSetWriter_GetFilePattern_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPDataSetWriter_GetGhostLevel_03(HandleRef pThis);

		public virtual int GetGhostLevel()
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_GetGhostLevel_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPDataSetWriter_GetNumberOfPieces_04(HandleRef pThis);

		public virtual int GetNumberOfPieces()
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_GetNumberOfPieces_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPDataSetWriter_GetStartPiece_05(HandleRef pThis);

		public virtual int GetStartPiece()
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_GetStartPiece_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPDataSetWriter_GetUseRelativeFileNames_06(HandleRef pThis);

		public virtual int GetUseRelativeFileNames()
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_GetUseRelativeFileNames_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPDataSetWriter_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPDataSetWriter_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPDataSetWriter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPDataSetWriter NewInstance()
		{
			vtkPDataSetWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPDataSetWriter.vtkPDataSetWriter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDataSetWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPDataSetWriter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPDataSetWriter SafeDownCast(vtkObjectBase o)
		{
			vtkPDataSetWriter vtkPDataSetWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPDataSetWriter.vtkPDataSetWriter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPDataSetWriter = (vtkPDataSetWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPDataSetWriter.Register(null);
				}
			}
			return vtkPDataSetWriter;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPDataSetWriter_SetEndPiece_12(HandleRef pThis, int _arg);

		public virtual void SetEndPiece(int _arg)
		{
			vtkPDataSetWriter.vtkPDataSetWriter_SetEndPiece_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPDataSetWriter_SetFilePattern_13(HandleRef pThis, string _arg);

		public virtual void SetFilePattern(string _arg)
		{
			vtkPDataSetWriter.vtkPDataSetWriter_SetFilePattern_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPDataSetWriter_SetGhostLevel_14(HandleRef pThis, int _arg);

		public virtual void SetGhostLevel(int _arg)
		{
			vtkPDataSetWriter.vtkPDataSetWriter_SetGhostLevel_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPDataSetWriter_SetNumberOfPieces_15(HandleRef pThis, int num);

		public void SetNumberOfPieces(int num)
		{
			vtkPDataSetWriter.vtkPDataSetWriter_SetNumberOfPieces_15(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPDataSetWriter_SetStartPiece_16(HandleRef pThis, int _arg);

		public virtual void SetStartPiece(int _arg)
		{
			vtkPDataSetWriter.vtkPDataSetWriter_SetStartPiece_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPDataSetWriter_SetUseRelativeFileNames_17(HandleRef pThis, int _arg);

		public virtual void SetUseRelativeFileNames(int _arg)
		{
			vtkPDataSetWriter.vtkPDataSetWriter_SetUseRelativeFileNames_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPDataSetWriter_UseRelativeFileNamesOff_18(HandleRef pThis);

		public virtual void UseRelativeFileNamesOff()
		{
			vtkPDataSetWriter.vtkPDataSetWriter_UseRelativeFileNamesOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPDataSetWriter_UseRelativeFileNamesOn_19(HandleRef pThis);

		public virtual void UseRelativeFileNamesOn()
		{
			vtkPDataSetWriter.vtkPDataSetWriter_UseRelativeFileNamesOn_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPDataSetWriter_Write_20(HandleRef pThis);

		public override int Write()
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_Write_20(base.GetCppThis());
		}
	}
}
