using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEnSight6BinaryReader : vtkEnSightReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEnSight6BinaryReader";

		public new static readonly string MRClassNameKey;

		static vtkEnSight6BinaryReader()
		{
			vtkEnSight6BinaryReader.MRClassNameKey = "class vtkEnSight6BinaryReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnSight6BinaryReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSight6BinaryReader"));
		}

		public vtkEnSight6BinaryReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSight6BinaryReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEnSight6BinaryReader New()
		{
			vtkEnSight6BinaryReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSight6BinaryReader.vtkEnSight6BinaryReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSight6BinaryReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEnSight6BinaryReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEnSight6BinaryReader.vtkEnSight6BinaryReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSight6BinaryReader_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEnSight6BinaryReader.vtkEnSight6BinaryReader_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSight6BinaryReader_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEnSight6BinaryReader.vtkEnSight6BinaryReader_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSight6BinaryReader_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEnSight6BinaryReader NewInstance()
		{
			vtkEnSight6BinaryReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSight6BinaryReader.vtkEnSight6BinaryReader_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSight6BinaryReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSight6BinaryReader_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEnSight6BinaryReader SafeDownCast(vtkObjectBase o)
		{
			vtkEnSight6BinaryReader vtkEnSight6BinaryReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSight6BinaryReader.vtkEnSight6BinaryReader_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnSight6BinaryReader = (vtkEnSight6BinaryReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnSight6BinaryReader.Register(null);
				}
			}
			return vtkEnSight6BinaryReader;
		}
	}
}
