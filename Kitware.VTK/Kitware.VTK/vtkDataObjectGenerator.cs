using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataObjectGenerator : vtkDataObjectAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectGenerator";

		public new static readonly string MRClassNameKey;

		static vtkDataObjectGenerator()
		{
			vtkDataObjectGenerator.MRClassNameKey = "class vtkDataObjectGenerator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectGenerator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectGenerator"));
		}

		public vtkDataObjectGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataObjectGenerator New()
		{
			vtkDataObjectGenerator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectGenerator.vtkDataObjectGenerator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataObjectGenerator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataObjectGenerator.vtkDataObjectGenerator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectGenerator_GetProgram_01(HandleRef pThis);

		public virtual string GetProgram()
		{
			return Marshal.PtrToStringAnsi(vtkDataObjectGenerator.vtkDataObjectGenerator_GetProgram_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectGenerator_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataObjectGenerator.vtkDataObjectGenerator_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectGenerator_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectGenerator.vtkDataObjectGenerator_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectGenerator_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataObjectGenerator NewInstance()
		{
			vtkDataObjectGenerator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectGenerator.vtkDataObjectGenerator_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectGenerator_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataObjectGenerator SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectGenerator vtkDataObjectGenerator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectGenerator.vtkDataObjectGenerator_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectGenerator = (vtkDataObjectGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectGenerator.Register(null);
				}
			}
			return vtkDataObjectGenerator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectGenerator_SetProgram_07(HandleRef pThis, string _arg);

		public virtual void SetProgram(string _arg)
		{
			vtkDataObjectGenerator.vtkDataObjectGenerator_SetProgram_07(base.GetCppThis(), _arg);
		}
	}
}
