using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEnSightGoldReader : vtkEnSightReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEnSightGoldReader";

		public new static readonly string MRClassNameKey;

		static vtkEnSightGoldReader()
		{
			vtkEnSightGoldReader.MRClassNameKey = "class vtkEnSightGoldReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnSightGoldReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSightGoldReader"));
		}

		public vtkEnSightGoldReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightGoldReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEnSightGoldReader New()
		{
			vtkEnSightGoldReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightGoldReader.vtkEnSightGoldReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightGoldReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEnSightGoldReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEnSightGoldReader.vtkEnSightGoldReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSightGoldReader_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEnSightGoldReader.vtkEnSightGoldReader_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSightGoldReader_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEnSightGoldReader.vtkEnSightGoldReader_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightGoldReader_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEnSightGoldReader NewInstance()
		{
			vtkEnSightGoldReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightGoldReader.vtkEnSightGoldReader_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightGoldReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightGoldReader_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEnSightGoldReader SafeDownCast(vtkObjectBase o)
		{
			vtkEnSightGoldReader vtkEnSightGoldReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightGoldReader.vtkEnSightGoldReader_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnSightGoldReader = (vtkEnSightGoldReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnSightGoldReader.Register(null);
				}
			}
			return vtkEnSightGoldReader;
		}
	}
}
