using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEnSightGoldBinaryReader : vtkEnSightReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEnSightGoldBinaryReader";

		public new static readonly string MRClassNameKey;

		static vtkEnSightGoldBinaryReader()
		{
			vtkEnSightGoldBinaryReader.MRClassNameKey = "class vtkEnSightGoldBinaryReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnSightGoldBinaryReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSightGoldBinaryReader"));
		}

		public vtkEnSightGoldBinaryReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightGoldBinaryReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEnSightGoldBinaryReader New()
		{
			vtkEnSightGoldBinaryReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightGoldBinaryReader.vtkEnSightGoldBinaryReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightGoldBinaryReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEnSightGoldBinaryReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEnSightGoldBinaryReader.vtkEnSightGoldBinaryReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSightGoldBinaryReader_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEnSightGoldBinaryReader.vtkEnSightGoldBinaryReader_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSightGoldBinaryReader_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEnSightGoldBinaryReader.vtkEnSightGoldBinaryReader_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightGoldBinaryReader_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEnSightGoldBinaryReader NewInstance()
		{
			vtkEnSightGoldBinaryReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightGoldBinaryReader.vtkEnSightGoldBinaryReader_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightGoldBinaryReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightGoldBinaryReader_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEnSightGoldBinaryReader SafeDownCast(vtkObjectBase o)
		{
			vtkEnSightGoldBinaryReader vtkEnSightGoldBinaryReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightGoldBinaryReader.vtkEnSightGoldBinaryReader_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnSightGoldBinaryReader = (vtkEnSightGoldBinaryReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnSightGoldBinaryReader.Register(null);
				}
			}
			return vtkEnSightGoldBinaryReader;
		}
	}
}
