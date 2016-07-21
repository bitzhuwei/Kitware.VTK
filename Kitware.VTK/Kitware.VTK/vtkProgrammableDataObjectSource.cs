using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProgrammableDataObjectSource : vtkDataObjectAlgorithm
	{
		public delegate void ProgrammableMethodCallbackType(IntPtr arg0);

		public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableDataObjectSource";

		public new static readonly string MRClassNameKey;

		static vtkProgrammableDataObjectSource()
		{
			vtkProgrammableDataObjectSource.MRClassNameKey = "class vtkProgrammableDataObjectSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProgrammableDataObjectSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableDataObjectSource"));
		}

		public vtkProgrammableDataObjectSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProgrammableDataObjectSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProgrammableDataObjectSource New()
		{
			vtkProgrammableDataObjectSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableDataObjectSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProgrammableDataObjectSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProgrammableDataObjectSource_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProgrammableDataObjectSource_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProgrammableDataObjectSource_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProgrammableDataObjectSource NewInstance()
		{
			vtkProgrammableDataObjectSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableDataObjectSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProgrammableDataObjectSource_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProgrammableDataObjectSource SafeDownCast(vtkObjectBase o)
		{
			vtkProgrammableDataObjectSource vtkProgrammableDataObjectSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProgrammableDataObjectSource = (vtkProgrammableDataObjectSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProgrammableDataObjectSource.Register(null);
				}
			}
			return vtkProgrammableDataObjectSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableDataObjectSource_SetExecuteMethod_06(HandleRef pThis, vtkProgrammableDataObjectSource.ProgrammableMethodCallbackType f, IntPtr arg);

		public void SetExecuteMethod(vtkProgrammableDataObjectSource.ProgrammableMethodCallbackType f, IntPtr arg)
		{
			vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_SetExecuteMethod_06(base.GetCppThis(), f, arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableDataObjectSource_SetExecuteMethodArgDelete_07(HandleRef pThis, vtkProgrammableDataObjectSource.ProgrammableMethodCallbackType f);

		public void SetExecuteMethodArgDelete(vtkProgrammableDataObjectSource.ProgrammableMethodCallbackType f)
		{
			vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_SetExecuteMethodArgDelete_07(base.GetCppThis(), f);
		}
	}
}
