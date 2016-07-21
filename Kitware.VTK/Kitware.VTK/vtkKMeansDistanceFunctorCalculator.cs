using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkKMeansDistanceFunctorCalculator : vtkKMeansDistanceFunctor
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkKMeansDistanceFunctorCalculator";

		public new static readonly string MRClassNameKey;

		static vtkKMeansDistanceFunctorCalculator()
		{
			vtkKMeansDistanceFunctorCalculator.MRClassNameKey = "class vtkKMeansDistanceFunctorCalculator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKMeansDistanceFunctorCalculator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKMeansDistanceFunctorCalculator"));
		}

		public vtkKMeansDistanceFunctorCalculator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKMeansDistanceFunctorCalculator New()
		{
			vtkKMeansDistanceFunctorCalculator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKMeansDistanceFunctorCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkKMeansDistanceFunctorCalculator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_GetDistanceExpression_01(HandleRef pThis);

		public virtual string GetDistanceExpression()
		{
			return Marshal.PtrToStringAnsi(vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_GetDistanceExpression_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_GetFunctionParser_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFunctionParser GetFunctionParser()
		{
			vtkFunctionParser vtkFunctionParser = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_GetFunctionParser_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFunctionParser = (vtkFunctionParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFunctionParser.Register(null);
				}
			}
			return vtkFunctionParser;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkKMeansDistanceFunctorCalculator_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkKMeansDistanceFunctorCalculator_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkKMeansDistanceFunctorCalculator NewInstance()
		{
			vtkKMeansDistanceFunctorCalculator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKMeansDistanceFunctorCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKMeansDistanceFunctorCalculator SafeDownCast(vtkObjectBase o)
		{
			vtkKMeansDistanceFunctorCalculator vtkKMeansDistanceFunctorCalculator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKMeansDistanceFunctorCalculator = (vtkKMeansDistanceFunctorCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKMeansDistanceFunctorCalculator.Register(null);
				}
			}
			return vtkKMeansDistanceFunctorCalculator;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkKMeansDistanceFunctorCalculator_SetDistanceExpression_08(HandleRef pThis, string _arg);

		public virtual void SetDistanceExpression(string _arg)
		{
			vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_SetDistanceExpression_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkKMeansDistanceFunctorCalculator_SetFunctionParser_09(HandleRef pThis, HandleRef arg0);

		public virtual void SetFunctionParser(vtkFunctionParser arg0)
		{
			vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_SetFunctionParser_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
