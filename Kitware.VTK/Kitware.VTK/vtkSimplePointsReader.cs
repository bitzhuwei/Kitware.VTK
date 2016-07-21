using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSimplePointsReader : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimplePointsReader";

		public new static readonly string MRClassNameKey;

		static vtkSimplePointsReader()
		{
			vtkSimplePointsReader.MRClassNameKey = "class vtkSimplePointsReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimplePointsReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimplePointsReader"));
		}

		public vtkSimplePointsReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSimplePointsReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimplePointsReader New()
		{
			vtkSimplePointsReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimplePointsReader.vtkSimplePointsReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimplePointsReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSimplePointsReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSimplePointsReader.vtkSimplePointsReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSimplePointsReader_GetFileName_01(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkSimplePointsReader.vtkSimplePointsReader_GetFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSimplePointsReader_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSimplePointsReader.vtkSimplePointsReader_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSimplePointsReader_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSimplePointsReader.vtkSimplePointsReader_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSimplePointsReader_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSimplePointsReader NewInstance()
		{
			vtkSimplePointsReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimplePointsReader.vtkSimplePointsReader_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimplePointsReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSimplePointsReader_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimplePointsReader SafeDownCast(vtkObjectBase o)
		{
			vtkSimplePointsReader vtkSimplePointsReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimplePointsReader.vtkSimplePointsReader_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimplePointsReader = (vtkSimplePointsReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimplePointsReader.Register(null);
				}
			}
			return vtkSimplePointsReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSimplePointsReader_SetFileName_07(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkSimplePointsReader.vtkSimplePointsReader_SetFileName_07(base.GetCppThis(), _arg);
		}
	}
}
