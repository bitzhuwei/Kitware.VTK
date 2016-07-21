using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEnSightMasterServerReader : vtkGenericEnSightReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEnSightMasterServerReader";

		public new static readonly string MRClassNameKey;

		static vtkEnSightMasterServerReader()
		{
			vtkEnSightMasterServerReader.MRClassNameKey = "class vtkEnSightMasterServerReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnSightMasterServerReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSightMasterServerReader"));
		}

		public vtkEnSightMasterServerReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightMasterServerReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEnSightMasterServerReader New()
		{
			vtkEnSightMasterServerReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightMasterServerReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEnSightMasterServerReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSightMasterServerReader_CanReadFile_01(HandleRef pThis, string fname);

		public new int CanReadFile(string fname)
		{
			return vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSightMasterServerReader_DetermineFileName_02(HandleRef pThis, int piece);

		public int DetermineFileName(int piece)
		{
			return vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_DetermineFileName_02(base.GetCppThis(), piece);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSightMasterServerReader_GetCurrentPiece_03(HandleRef pThis);

		public virtual int GetCurrentPiece()
		{
			return vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_GetCurrentPiece_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightMasterServerReader_GetPieceCaseFileName_04(HandleRef pThis);

		public virtual string GetPieceCaseFileName()
		{
			return Marshal.PtrToStringAnsi(vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_GetPieceCaseFileName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSightMasterServerReader_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSightMasterServerReader_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightMasterServerReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEnSightMasterServerReader NewInstance()
		{
			vtkEnSightMasterServerReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightMasterServerReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightMasterServerReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEnSightMasterServerReader SafeDownCast(vtkObjectBase o)
		{
			vtkEnSightMasterServerReader vtkEnSightMasterServerReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnSightMasterServerReader = (vtkEnSightMasterServerReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnSightMasterServerReader.Register(null);
				}
			}
			return vtkEnSightMasterServerReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkEnSightMasterServerReader_SetCurrentPiece_10(HandleRef pThis, int _arg);

		public virtual void SetCurrentPiece(int _arg)
		{
			vtkEnSightMasterServerReader.vtkEnSightMasterServerReader_SetCurrentPiece_10(base.GetCppThis(), _arg);
		}
	}
}
